﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Padrrif;

#nullable disable

namespace Padrrif.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240627181648_initnal")]
    partial class initnal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Padrrif.AnimalDamage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int?>("AffectedNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("DamageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("DamageType")
                        .HasColumnType("longtext");

                    b.Property<string>("Insurance")
                        .HasColumnType("longtext");

                    b.Property<string>("InsuranceProvider")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<double?>("PriceBeforeDamage")
                        .HasColumnType("double");

                    b.Property<double?>("ProductionRate")
                        .HasColumnType("double");

                    b.Property<int?>("TotalNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DamageId");

                    b.ToTable("AnimalDamage");
                });

            modelBuilder.Entity("Padrrif.Comitee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Comitee");
                });

            modelBuilder.Entity("Padrrif.Damage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BasinNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ChildrenUnderEighteen")
                        .HasColumnType("int");

                    b.Property<string>("CompanyOrFactoryName")
                        .HasColumnType("longtext");

                    b.Property<string>("ContractDuration")
                        .HasColumnType("longtext");

                    b.Property<int?>("ContractorId")
                        .HasColumnType("int");

                    b.Property<string>("ContractorName")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("DamageRateLastFiveYears")
                        .HasColumnType("double");

                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DocumentId"));

                    b.Property<string>("DocumentNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("DocumentsPaths")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("EducationLevelId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("EventDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EventDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("EventDuration")
                        .HasColumnType("longtext");

                    b.Property<int>("FamilyMembers")
                        .HasColumnType("int");

                    b.Property<Guid>("FarmerId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsAnimalTremblingChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsBirdFluChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDroughtChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsExtremeTemperatureDropChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsExtremeTemperatureRiseChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsFloodChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsFrostChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsHailChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsHarmfulWeedsChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsIsraeliArmyChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsLocustChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsMarketClosedChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsMilitaryZoneChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOtherProfession")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSeparationWallChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSnowChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsStrongWindChecked")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LandNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double?>("Latitude")
                        .HasColumnType("double");

                    b.Property<string>("LocationPaths")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double?>("Longitude")
                        .HasColumnType("double");

                    b.Property<double>("MonthlyIncomeFromAgriculture")
                        .HasColumnType("double");

                    b.Property<string>("OtherTabTwoText")
                        .HasColumnType("longtext");

                    b.Property<Guid>("OwnershipTypeId")
                        .HasColumnType("char(36)");

                    b.Property<int>("RegionType")
                        .HasColumnType("int");

                    b.Property<double>("ReliancePercentage")
                        .HasColumnType("double");

                    b.Property<string>("SettlementName")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<double?>("TotalArea")
                        .HasColumnType("double");

                    b.Property<Guid>("VillageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("otherTabThreeText")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DocumentId")
                        .IsUnique();

                    b.HasIndex("EducationLevelId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OwnershipTypeId");

                    b.HasIndex("VillageId");

                    b.ToTable("Damage");
                });

            modelBuilder.Entity("Padrrif.EducationLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EducationLevel");
                });

            modelBuilder.Entity("Padrrif.EmployeePrivilieges", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PrivliegeId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("EmployeeId", "PrivliegeId");

                    b.HasIndex("PrivliegeId");

                    b.ToTable("EmployeePrivilieges");
                });

            modelBuilder.Entity("Padrrif.Entities.Priviliege", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Priviliege");
                });

            modelBuilder.Entity("Padrrif.FarmFacilities", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double?>("ActualDamageArea")
                        .HasColumnType("double");

                    b.Property<string>("CategoryFacilities")
                        .HasColumnType("longtext");

                    b.Property<string>("DamageFacilitiesType")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DamageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FacilitiesType")
                        .HasColumnType("longtext");

                    b.Property<string>("InsuranceFacilities")
                        .HasColumnType("longtext");

                    b.Property<string>("InsuranceProvider")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LicenseFacilities")
                        .HasColumnType("longtext");

                    b.Property<string>("LicenseProvider")
                        .HasColumnType("longtext");

                    b.Property<double?>("TotalAffectedArea")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DamageId");

                    b.ToTable("FarmFacilities");
                });

            modelBuilder.Entity("Padrrif.FisheryDamage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int?>("AffectedNumber")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DamageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FishDamageType")
                        .HasColumnType("longtext");

                    b.Property<string>("Insurance")
                        .HasColumnType("longtext");

                    b.Property<string>("InsuranceProvider")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<double?>("PriceBeforeDamage")
                        .HasColumnType("double");

                    b.Property<double?>("ProductionRate")
                        .HasColumnType("double");

                    b.Property<int?>("TotalNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DamageId");

                    b.ToTable("FisheryDamage");
                });

            modelBuilder.Entity("Padrrif.Governorate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Governorate");
                });

            modelBuilder.Entity("Padrrif.Notifaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime?>("SeenAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifaction");
                });

            modelBuilder.Entity("Padrrif.OwnerShipType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("OwnerShipType");
                });

            modelBuilder.Entity("Padrrif.PlantDamage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double?>("ActualDamageArea")
                        .HasColumnType("double");

                    b.Property<string>("CropAge")
                        .HasColumnType("longtext");

                    b.Property<string>("CropDamage")
                        .HasColumnType("longtext");

                    b.Property<string>("CropType")
                        .HasColumnType("longtext");

                    b.Property<string>("CropTypeMethod")
                        .HasColumnType("longtext");

                    b.Property<string>("CropTypeOption")
                        .HasColumnType("longtext");

                    b.Property<Guid>("DamageId")
                        .HasColumnType("char(36)");

                    b.Property<double?>("EstimatedPrice")
                        .HasColumnType("double");

                    b.Property<double?>("EstimatedProductionRate")
                        .HasColumnType("double");

                    b.Property<string>("FruitingStage")
                        .HasColumnType("longtext");

                    b.Property<string>("Insurance")
                        .HasColumnType("longtext");

                    b.Property<string>("InsuranceProvider")
                        .HasColumnType("longtext");

                    b.Property<string>("IrrigationMethod")
                        .HasColumnType("longtext");

                    b.Property<string>("IrrigationOption")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("OtherCropTextFieldValue")
                        .HasColumnType("longtext");

                    b.Property<string>("OtherTextFieldValue")
                        .HasColumnType("longtext");

                    b.Property<double?>("PercentageDamage")
                        .HasColumnType("double");

                    b.Property<double?>("TotalAffectedArea")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DamageId");

                    b.ToTable("PlantDamage");
                });

            modelBuilder.Entity("Padrrif.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("ComiteeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("DocumentsPaths")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<Guid>("GovernorateId")
                        .HasColumnType("char(36)");

                    b.Property<int>("IdentityNumber")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("MobilePhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComiteeId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("GovernorateId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Padrrif.Village", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Village");
                });

            modelBuilder.Entity("Padrrif.WorkHours", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double?>("DailyWorkHours")
                        .HasColumnType("double");

                    b.Property<Guid>("DamageId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<double?>("WeeklyWorkHours")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DamageId");

                    b.ToTable("WorkHours");
                });

            modelBuilder.Entity("Padrrif.AnimalDamage", b =>
                {
                    b.HasOne("Padrrif.Damage", "Damage")
                        .WithMany("AnimalDamages")
                        .HasForeignKey("DamageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Damage");
                });

            modelBuilder.Entity("Padrrif.Damage", b =>
                {
                    b.HasOne("Padrrif.EducationLevel", "EducationLevel")
                        .WithMany("Damages")
                        .HasForeignKey("EducationLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Padrrif.User", "Employee")
                        .WithMany("Damages")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Padrrif.OwnerShipType", "OwnerShipType")
                        .WithMany("Damages")
                        .HasForeignKey("OwnershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Padrrif.Village", "Village")
                        .WithMany("Damages")
                        .HasForeignKey("VillageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationLevel");

                    b.Navigation("Employee");

                    b.Navigation("OwnerShipType");

                    b.Navigation("Village");
                });

            modelBuilder.Entity("Padrrif.EmployeePrivilieges", b =>
                {
                    b.HasOne("Padrrif.User", "User")
                        .WithMany("EmployeePrivilieges")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Padrrif.Entities.Priviliege", "Priviliege")
                        .WithMany("EmployeePrivilieges")
                        .HasForeignKey("PrivliegeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Priviliege");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Padrrif.FarmFacilities", b =>
                {
                    b.HasOne("Padrrif.Damage", "Damage")
                        .WithMany("FarmFacilities")
                        .HasForeignKey("DamageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Damage");
                });

            modelBuilder.Entity("Padrrif.FisheryDamage", b =>
                {
                    b.HasOne("Padrrif.Damage", "Damage")
                        .WithMany("FisheryDamages")
                        .HasForeignKey("DamageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Damage");
                });

            modelBuilder.Entity("Padrrif.Notifaction", b =>
                {
                    b.HasOne("Padrrif.User", "User")
                        .WithMany("Notifactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Padrrif.PlantDamage", b =>
                {
                    b.HasOne("Padrrif.Damage", "Damage")
                        .WithMany("PlantDamages")
                        .HasForeignKey("DamageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Damage");
                });

            modelBuilder.Entity("Padrrif.User", b =>
                {
                    b.HasOne("Padrrif.Comitee", "Comittee")
                        .WithMany("Employees")
                        .HasForeignKey("ComiteeId");

                    b.HasOne("Padrrif.Governorate", "Governorate")
                        .WithMany("Users")
                        .HasForeignKey("GovernorateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comittee");

                    b.Navigation("Governorate");
                });

            modelBuilder.Entity("Padrrif.WorkHours", b =>
                {
                    b.HasOne("Padrrif.Damage", "Damage")
                        .WithMany("WorkHours")
                        .HasForeignKey("DamageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Damage");
                });

            modelBuilder.Entity("Padrrif.Comitee", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Padrrif.Damage", b =>
                {
                    b.Navigation("AnimalDamages");

                    b.Navigation("FarmFacilities");

                    b.Navigation("FisheryDamages");

                    b.Navigation("PlantDamages");

                    b.Navigation("WorkHours");
                });

            modelBuilder.Entity("Padrrif.EducationLevel", b =>
                {
                    b.Navigation("Damages");
                });

            modelBuilder.Entity("Padrrif.Entities.Priviliege", b =>
                {
                    b.Navigation("EmployeePrivilieges");
                });

            modelBuilder.Entity("Padrrif.Governorate", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Padrrif.OwnerShipType", b =>
                {
                    b.Navigation("Damages");
                });

            modelBuilder.Entity("Padrrif.User", b =>
                {
                    b.Navigation("Damages");

                    b.Navigation("EmployeePrivilieges");

                    b.Navigation("Notifactions");
                });

            modelBuilder.Entity("Padrrif.Village", b =>
                {
                    b.Navigation("Damages");
                });
#pragma warning restore 612, 618
        }
    }
}
