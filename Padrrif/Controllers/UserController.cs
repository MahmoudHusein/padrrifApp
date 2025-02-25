﻿namespace Padrrif.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IRepository<User> _repository;

        public UserController(IUserUnitOfWork unitOfWork, IHttpContextAccessor contextAccessor,IRepository<User> repository) {
            _unitOfWork = unitOfWork;
            _contextAccessor = contextAccessor;
            _repository = repository;
        }

        [Authorize(Roles = nameof(RoleEnum.Empolyee))]
        [HttpGet("unconfirmed-users")]
        public async Task<IActionResult> Get()
        {
            List<User> users = await _unitOfWork.GetAllUnConfirmedUsers();

            return Ok(users);   
        }
        [Authorize(Roles = nameof(RoleEnum.Empolyee))]
        [HttpPost("confirm-user")]
        public async Task<IActionResult> ConfirmUser(int id)
        {
            bool isUpdated = await _unitOfWork.ConfirmUser(id);

            if (isUpdated)
                return Ok();

            return BadRequest();
        }

        [HttpGet("User-List")]
        public async Task<IActionResult> GetUserListWithEnum(int enid)
        {
            List<User>? users = await _unitOfWork.GetAllUserBasedOnStatuse(enid);
            return Ok(users);
        }
        [HttpGet("User-List-Id")]
        public async Task<IActionResult> GetUserWithIdentityNo(int id)
        {
            User? user = await _unitOfWork.GetUserWithIdentityNumber(id);
            if(user != null)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest("there is no User With Id Check the Id again");
            }
        }
        [HttpGet("User-List-Name")]
        public async Task<IActionResult> GetUserWithName(string name)
        {
            List<User>? users = await _unitOfWork.GetUserWithName(name);
            if ( users != null)
            {
                return Ok(users);
            }
            else
            {
                return BadRequest("there is no User With this Name Check your Identity Number again");
            }
        }
        [Authorize(Roles = nameof(RoleEnum.Farmer))]
        [HttpPut("Update-user")]
        public async Task<IActionResult> UpdateUser(User user)
        {
           string res =  await _unitOfWork.UpdateUser(user);
            return Ok(res);
        }
        [HttpGet("Get_User_WithToken")]
        public async Task<IActionResult> GetUserWithToken()
        {
            Guid id = _contextAccessor.GetUserId();
            User? UserFromDb = await _repository.GetById(id);
            return Ok(UserFromDb);
        }
        [HttpGet("Governorate-Users")]
        public async Task<IActionResult> GetGovernorateUsers(int role, Guid governorateId)
        {
            List<User>? users = await _unitOfWork.GetGovernorateUsers(role, governorateId);
            if (users != null)
            {
                return Ok(users);
            }
            else
            {
                return NotFound("No users found with the specified filters.");
            }
        }
    }
}
