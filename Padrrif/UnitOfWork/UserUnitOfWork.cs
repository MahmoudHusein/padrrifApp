using Microsoft.AspNetCore.SignalR;
using Padrrif.Dto;
using Padrrif.Entities;
using Padrrif.UnitOfWork.Interface;
namespace Padrrif;
public class UserUnitOfWork : UnitOfWork<User>, IUserUnitOfWork
{
    private readonly IRepository<User> _repository;
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly NotificationHubConecctedUsers _conecctedUsers;
    private readonly IRepository<Notifaction> _notifactionRepository;
    private readonly IHubContext<NotificationHub, INotificationClient> _hubContext;
    public UserUnitOfWork(IRepository<User> repository,
        IHttpContextAccessor contextAccessor) : base(repository){
        _repository = repository;
        _contextAccessor = contextAccessor;

    }

    public async Task<List<User>> GetAllUnConfirmedUsers()
    {
        List<User> users = await Read(q => q.Where(e => e.IsConfirmed == false));
        return users;
    }

    public async Task<bool> ConfirmUser(int userId)
    {
        User? userFromDb = await _repository.GetSingleEntityWithSomeCondiition(q => q.Where(u => u.IdentityNumber == userId));

        if (userFromDb == null)
            return false;

        userFromDb.IsConfirmed = true;

        try
        {
            await Update(userFromDb);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<List<User>?> GetAllUserBasedOnStatuse(int userenum)
    {
        Guid userId = _contextAccessor.GetUserId();
        User? userFromDb = await _repository.GetById(userId);
        if (userFromDb == null)
            throw new SecurityTokenArgumentException("invalid Token");
        
        List<User>? users = null;
        RoleEnum role = (RoleEnum)userenum;

        if( userFromDb != null)
        users  = await _repository.GetList(q => q.Where(e => e.Role == role && e.GovernorateId == userFromDb.GovernorateId&& e.IsConfirmed==true));

        return users;
    }

    public async Task<User?> GetUserWithIdentityNumber(int id)
    {
        User? userFromDb = null;
        userFromDb = await _repository.GetSingleEntityWithSomeCondiition(q => q.Where(e => e.IdentityNumber == id));
        return userFromDb;
    }

    public async Task<List<User>?> GetUserWithName(string name)
    {
        List<User>? userFromDb = null;
        userFromDb = await _repository.GetList(q=> q.Where(e => e.Name == name));
        return userFromDb;
    }
    public async Task<string> UpdateUser(User user)
    {
        Guid id = _contextAccessor.GetUserId();
        string res = string.Empty;

        User? userFromDb = await _repository.GetSingleEntityWithSomeCondiition(q => q.Where(e => e.Id == id));
        if (userFromDb == null)
            return "Wrong Credentials";

        if (!string.IsNullOrEmpty(user.Name))
            userFromDb.Name = user.Name;

        if (!string.IsNullOrEmpty(user.Email))
            userFromDb.Email = user.Email;

        if (!string.IsNullOrEmpty(user.PhoneNumber))
            userFromDb.PhoneNumber = user.PhoneNumber;

        if (!string.IsNullOrEmpty(user.Password))
            userFromDb.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

        if (!string.IsNullOrEmpty(user.City))
            userFromDb.City = user.City;

        if (!string.IsNullOrEmpty(user.ImagePath))
            userFromDb.ImagePath = user.ImagePath;

        if (user.Governorate != null)
            userFromDb.Governorate = user.Governorate;

        await _repository.Update(userFromDb);

        // إرسال الإشعارات بناءً على دور المستخدم
        if (userFromDb.Role == RoleEnum.Farmer)
        {
            List<User> employees = await _repository.GetList(q => q.Where(e => e.Role == RoleEnum.Empolyee && e.GovernorateId == userFromDb.GovernorateId));
            List<HubConnectedUser> onlineUsers = _conecctedUsers.HubConnectedUsers.Where(e => e.Role == RoleEnum.Empolyee && e.GovernorateId == userFromDb.GovernorateId).ToList();
            List<Guid> onlineUsersIds = onlineUsers.Select(e => e.Id).ToList();
            List<Guid> offlineEmployeesIds = employees.Where(e => !onlineUsersIds.Contains(e.Id)).Select(e => e.Id).ToList();
            List<string> userHubIds = onlineUsers.Select(e => e.ConnectionId).ToList();

            string notificationMessage = $"المزارع {userFromDb.Name} قام بتحديث بياناته.";

            foreach (var connId in userHubIds)
                await _hubContext.Clients.Client(connId).ReciveNotification(notificationMessage);

            foreach (var empId in offlineEmployeesIds)
            {
                Notifaction notifaction = new()
                {
                    Message = notificationMessage,
                    UserId = id,
                    SeenAt = null
                };
                await _notifactionRepository.Add(notifaction);
            }
        }
        else if (userFromDb.Role == RoleEnum.Empolyee)
        {
            List<User> admins = await _repository.GetList(q => q.Where(e => e.Role == RoleEnum.Admin));
            List<HubConnectedUser> onlineAdmins = _conecctedUsers.HubConnectedUsers.Where(e => e.Role == RoleEnum.Admin).ToList();
            List<Guid> onlineAdminIds = onlineAdmins.Select(e => e.Id).ToList();
            List<Guid> offlineAdminIds = admins.Where(e => !onlineAdminIds.Contains(e.Id)).Select(e => e.Id).ToList();
            List<string> adminHubIds = onlineAdmins.Select(e => e.ConnectionId).ToList();

            string notificationMessage = $"الموظف {userFromDb.Name} قام بتحديث بياناته.";

            foreach (var connId in adminHubIds)
                await _hubContext.Clients.Client(connId).ReciveNotification(notificationMessage);

            foreach (var adminId in offlineAdminIds)
            {
                Notifaction notifaction = new()
                {
                    Message = notificationMessage,
                    UserId = id,
                    SeenAt = null
                };
                await _notifactionRepository.Add(notifaction);
            }
        }

        return "User has been updated successfully";
    }

    public async Task<List<User>?> GetGovernorateUsers(int role, Guid governorateId)
    {
        RoleEnum userRole = (RoleEnum)role;
        List<User>? users = await _repository.GetList(q => q.Where(e => e.Role == userRole && e.GovernorateId == governorateId && e.IsConfirmed));
        return users;
    }
}