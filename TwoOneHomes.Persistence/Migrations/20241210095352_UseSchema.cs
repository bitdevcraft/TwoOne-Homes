using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwoOneHomes.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "management");

            migrationBuilder.EnsureSchema(
                name: "core");

            migrationBuilder.EnsureSchema(
                name: "web");

            migrationBuilder.CreateTable(
                name: "Audits",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Operation = table.Column<string>(type: "text", nullable: true),
                    TableName = table.Column<string>(type: "text", nullable: true),
                    RecordId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormLayouts",
                schema: "web",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SmallText = table.Column<string>(type: "text", nullable: true),
                    Placeholder = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    ObjectType = table.Column<string>(type: "text", nullable: true),
                    Required = table.Column<bool>(type: "boolean", nullable: false),
                    ReadOnly = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormLayouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                schema: "web",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Label = table.Column<string>(type: "text", nullable: true),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    RouterLinkArray = table.Column<string>(type: "text", nullable: true),
                    UrlArray = table.Column<string>(type: "text", nullable: true),
                    ParentId = table.Column<string>(type: "character varying(26)", nullable: true),
                    CanDelete = table.Column<bool>(type: "boolean", nullable: false),
                    Hierarchy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Menus_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "web",
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditEntries",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    FieldName = table.Column<string>(type: "text", nullable: true),
                    OldValue = table.Column<string>(type: "text", nullable: true),
                    NewValue = table.Column<string>(type: "text", nullable: true),
                    AuditId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditEntries_Audits_AuditId",
                        column: x => x.AuditId,
                        principalSchema: "core",
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "core",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                schema: "core",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "character varying(26)", nullable: false),
                    PermissionId = table.Column<string>(type: "character varying(26)", nullable: false),
                    Id = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalSchema: "core",
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "core",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    OwnerId = table.Column<string>(type: "character varying(26)", nullable: true),
                    ParentAccountId = table.Column<string>(type: "character varying(26)", nullable: false),
                    BookingId = table.Column<string>(type: "character varying(26)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Accounts_ParentAccountId",
                        column: x => x.ParentAccountId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlans",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentPlans_Accounts_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    OwnerId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Accounts_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    ManagerId = table.Column<string>(type: "character varying(26)", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    MiddleName = table.Column<string>(type: "text", nullable: true),
                    Suffix = table.Column<string>(type: "text", nullable: true),
                    Salutation = table.Column<string>(type: "text", nullable: true),
                    Mobile = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Fax = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    AccountId = table.Column<string>(type: "character varying(26)", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Users_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlanMilestones",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    TotalPercentage = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentCount = table.Column<int>(type: "integer", nullable: false),
                    IntervalType = table.Column<int>(type: "integer", nullable: false),
                    IntervalCount = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    StartAfterHandover = table.Column<bool>(type: "boolean", nullable: false),
                    PaymentPlanId = table.Column<string>(type: "character varying(26)", nullable: false),
                    OwnerId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlanMilestones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentPlanMilestones_Accounts_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentPlanMilestones_PaymentPlans_PaymentPlanId",
                        column: x => x.PaymentPlanId,
                        principalSchema: "management",
                        principalTable: "PaymentPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectInstallmentPlan",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    ProjectId = table.Column<string>(type: "character varying(26)", nullable: false),
                    PaymentPlanId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectInstallmentPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectInstallmentPlan_PaymentPlans_PaymentPlanId",
                        column: x => x.PaymentPlanId,
                        principalSchema: "management",
                        principalTable: "PaymentPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectInstallmentPlan_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "management",
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    IsFurnished = table.Column<bool>(type: "boolean", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: true),
                    LocationView = table.Column<string>(type: "text", nullable: true),
                    BalconyAreaSqFt = table.Column<decimal>(type: "numeric", nullable: false),
                    CommonAreaSqFt = table.Column<decimal>(type: "numeric", nullable: false),
                    UnitAreaSqFt = table.Column<decimal>(type: "numeric", nullable: false),
                    UseType = table.Column<int>(type: "integer", nullable: false),
                    BuildingNo = table.Column<string>(type: "text", nullable: true),
                    BuildingFloorCount = table.Column<int>(type: "integer", nullable: false),
                    UnitNumber = table.Column<string>(type: "text", nullable: true),
                    Floor = table.Column<string>(type: "text", nullable: true),
                    RoomCount = table.Column<int>(type: "integer", nullable: false),
                    BathroomCount = table.Column<int>(type: "integer", nullable: false),
                    ParkingCount = table.Column<int>(type: "integer", nullable: false),
                    VillaNumber = table.Column<string>(type: "text", nullable: true),
                    PlotNumber = table.Column<string>(type: "text", nullable: true),
                    PricePerSqFt = table.Column<decimal>(type: "numeric", nullable: true),
                    AreaSqFt = table.Column<double>(type: "double precision", nullable: true),
                    AreaSqM = table.Column<double>(type: "double precision", nullable: true),
                    PaymentPlanId = table.Column<string>(type: "character varying(26)", nullable: false),
                    RentalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    MaxOccupancy = table.Column<int>(type: "integer", nullable: false),
                    Rules = table.Column<string>(type: "text", nullable: true),
                    LeasePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    LeaseDurationMonths = table.Column<int>(type: "integer", nullable: false),
                    LeasePaymentTerm = table.Column<int>(type: "integer", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: true),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    OwnerId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ProjectId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Accounts_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PaymentPlans_PaymentPlanId",
                        column: x => x.PaymentPlanId,
                        principalSchema: "management",
                        principalTable: "PaymentPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalSchema: "management",
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserTokens",
                schema: "core",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_IdentityUserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    Token = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Revoked = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsUsed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivities",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ActivityType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ActivityData = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IpAddress = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    DeviceInfo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActivities_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                schema: "core",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                schema: "core",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "core",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    RoleId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "core",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlanMilestoneFees",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AmountOrRate = table.Column<decimal>(type: "numeric", nullable: false),
                    IsRecurring = table.Column<bool>(type: "boolean", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    MilestoneId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlanMilestoneFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentPlanMilestoneFees_PaymentPlanMilestones_MilestoneId",
                        column: x => x.MilestoneId,
                        principalSchema: "management",
                        principalTable: "PaymentPlanMilestones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SalesPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    MainCustomerId = table.Column<string>(type: "character varying(26)", nullable: false),
                    PropertyId = table.Column<string>(type: "character varying(26)", nullable: false),
                    OwnerId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Accounts_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalSchema: "management",
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingBrokers",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    AccountId = table.Column<string>(type: "character varying(26)", nullable: false),
                    BookingId = table.Column<string>(type: "character varying(26)", nullable: false),
                    MainOwner = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingBrokers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingBrokers_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingBrokers_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalSchema: "management",
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingCustomers",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    BookingId = table.Column<string>(type: "character varying(26)", nullable: false),
                    MainOwner = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingCustomers_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalSchema: "management",
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingCustomers_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commissions",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Percentage = table.Column<decimal>(type: "numeric", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    BookingId = table.Column<string>(type: "character varying(26)", nullable: false),
                    BrokerId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commissions_Accounts_BrokerId",
                        column: x => x.BrokerId,
                        principalSchema: "management",
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commissions_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalSchema: "management",
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentIntents",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: true),
                    IntentStatus = table.Column<int>(type: "integer", nullable: false),
                    StripePaymentIntentId = table.Column<string>(type: "text", nullable: true),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true),
                    ClientSecret = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false),
                    BookingId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentIntents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentIntents_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalSchema: "management",
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentIntents_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingBrokerAgents",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    BookingBrokerId = table.Column<string>(type: "character varying(26)", nullable: false),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingBrokerAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingBrokerAgents_BookingBrokers_BookingBrokerId",
                        column: x => x.BookingBrokerId,
                        principalSchema: "management",
                        principalTable: "BookingBrokers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingBrokerAgents_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    Currency = table.Column<string>(type: "text", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TransactionId = table.Column<string>(type: "text", nullable: true),
                    TransactionType = table.Column<int>(type: "integer", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true),
                    PaymentIntentId = table.Column<string>(type: "character varying(26)", nullable: false),
                    UserId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentIntents_PaymentIntentId",
                        column: x => x.PaymentIntentId,
                        principalSchema: "management",
                        principalTable: "PaymentIntents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "core",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refunds",
                schema: "management",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(26)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedOnUtc = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    RefundAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    RefundDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StripeRefundId = table.Column<string>(type: "text", nullable: true),
                    TransactionId = table.Column<string>(type: "character varying(26)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refunds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refunds_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalSchema: "management",
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "management",
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "FirstName", "LastName", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JEQZTJ942533C2F0WEXHCXDS", new DateTime(2024, 12, 10, 9, 53, 52, 420, DateTimeKind.Utc).AddTicks(2270), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" },
                    { "01JEQZTJ946XNWYTX0DZQR3CSJ", new DateTime(2024, 12, 10, 9, 53, 52, 420, DateTimeKind.Utc).AddTicks(2262), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" },
                    { "01JEQZTJ94FXG50W9X39TS2PZW", new DateTime(2024, 12, 10, 9, 53, 52, 420, DateTimeKind.Utc).AddTicks(2273), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JEQZTJ94H538GXPJCETJWHE8", new DateTime(2024, 12, 10, 9, 53, 52, 420, DateTimeKind.Utc).AddTicks(2267), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" },
                    { "01JEQZTJ94QJDSXR4QYFXX271C", new DateTime(2024, 12, 10, 9, 53, 52, 420, DateTimeKind.Utc).AddTicks(2275), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" }
                });

            migrationBuilder.InsertData(
                schema: "web",
                table: "Menus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "0000000000775C83ZMHS46KZB9", false, 1, "pi pi-fw pi-cog", "Setup", null, null, null },
                    { "0000000000FPSYZH3GPW5MSXK9", true, 0, "pi pi-fw pi-wallet", "Sales", null, null, null }
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "Permissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JEQZTJ9K28MW4FDPKWQN8ZCY", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JEQZTJ9K2G11138YC7TJZ245", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JEQZTJ9K34NMM6BGAWPDAQT9", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JEQZTJ9K52M7C25RHPPW42DR", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JEQZTJ9K5X6M4XE2D7DKXBTQ", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JEQZTJ9K5XJNDWC5T8DKSTMJ", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JEQZTJ9K96E1BRQQG036QSGG", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JEQZTJ9KDZPW4TYN4ZNH7DF7", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JEQZTJ9KGWXBPX52HF6Q4J5C", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JEQZTJ9KNJ4C6E9PQGFR2RQ3", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JEQZTJ9KW5NJRZ5WHASAKAWJ", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JEQZTJ9KZDJFFPQYKK0GYW14", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" }
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000000000000000000001", null, "SystemAdministrator", "SYSTEMADMINISTRATOR" },
                    { "00000000000000000000000002", null, "Administrator", "ADMINISTRATOR" },
                    { "00000000000000000000000003", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                schema: "web",
                table: "Menus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "000000000065ET5P858WE44ESH", true, 0, "pi pi-fw pi-id-card", "Leads", "0000000000FPSYZH3GPW5MSXK9", null, null },
                    { "00000000006D8TXH0VSKS8A16T", false, 0, "pi pi-fw pi-users", "Administrations", "0000000000775C83ZMHS46KZB9", null, null },
                    { "00000000008CPGH1XH0C8H43XB", true, 2, "pi pi-fw pi-building", "Accounts", "0000000000FPSYZH3GPW5MSXK9", null, null },
                    { "00000000009XWDPJSQF96B4NP7", true, 3, "pi pi-fw pi-bookmark", "Opportunities", "0000000000FPSYZH3GPW5MSXK9", null, null },
                    { "0000000000RS4BRNHEH542PJ7C", false, 1, "pi pi-fw pi-wrench", "Settings", "0000000000775C83ZMHS46KZB9", null, null },
                    { "0000000000TMSKXZG0TQS8KH4E", true, 1, "pi pi-fw pi-address-book", "Contacts", "0000000000FPSYZH3GPW5MSXK9", null, null },
                    { "000000000010A44W9QKCDF8R01", true, 0, "pi pi-fw pi-plus", "New Lead", "000000000065ET5P858WE44ESH", "/r/Leads/new", null },
                    { "000000000029GN3AW98KG9NSW0", true, 1, "pi pi-fw pi-list", "List View", "000000000065ET5P858WE44ESH", "/r/Leads/list-view", null },
                    { "00000000007TXYNB9SCDNX2PBW", true, 1, "pi pi-fw pi-list", "List View", "00000000009XWDPJSQF96B4NP7", "/r/Opportunities/list-view", null },
                    { "000000000091AF12TDAYDRJWWX", false, 2, "pi pi-fw ", "Users", "00000000006D8TXH0VSKS8A16T", "/setup/administrations/user", null },
                    { "000000000091VTD5TYNF1KWWPW", false, 0, "pi pi-fw", "Menu Settings", "0000000000RS4BRNHEH542PJ7C", "/setup/settings/menu", null },
                    { "0000000000AA85C44J7Z6EHSK9", true, 0, "pi pi-fw pi-plus", "New Account", "00000000008CPGH1XH0C8H43XB", "/r/Accounts/new", null },
                    { "0000000000B9VEPEMT33QKH8GJ", true, 0, "pi pi-fw pi-plus", "New Contact", "0000000000TMSKXZG0TQS8KH4E", "/r/Contacts/new", null },
                    { "0000000000BY6K569JMAXKBFQ4", true, 1, "pi pi-fw pi-list", "List View", "0000000000TMSKXZG0TQS8KH4E", "/r/Contacts/list-view", null },
                    { "0000000000DB9RAE6NFQ7D947H", true, 0, "pi pi-fw pi-plus", "New Opportunity", "00000000009XWDPJSQF96B4NP7", "/r/Opportunities/new", null },
                    { "0000000000E1X6ZFQH12PK4K79", false, 0, "pi pi-fw", "Permissions", "00000000006D8TXH0VSKS8A16T", "/setup/administrations/permission", null },
                    { "0000000000KZS5Z9FTHRW81DB8", false, 1, "pi pi-fw ", "Roles", "00000000006D8TXH0VSKS8A16T", "/setup/administrations/role", null },
                    { "0000000000ZZZNEZFA5KW8VQ49", true, 1, "pi pi-fw pi-list", "List View", "00000000008CPGH1XH0C8H43XB", "/r/Accounts/list-view", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_BookingId",
                schema: "management",
                table: "Accounts",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_OwnerId",
                schema: "management",
                table: "Accounts",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ParentAccountId",
                schema: "management",
                table: "Accounts",
                column: "ParentAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditEntries_AuditId",
                schema: "core",
                table: "AuditEntries",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingBrokerAgents_BookingBrokerId",
                schema: "management",
                table: "BookingBrokerAgents",
                column: "BookingBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingBrokerAgents_UserId",
                schema: "management",
                table: "BookingBrokerAgents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingBrokers_AccountId",
                schema: "management",
                table: "BookingBrokers",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingBrokers_BookingId",
                schema: "management",
                table: "BookingBrokers",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCustomers_BookingId",
                schema: "management",
                table: "BookingCustomers",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCustomers_UserId",
                schema: "management",
                table: "BookingCustomers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_OwnerId",
                schema: "management",
                table: "Bookings",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PropertyId",
                schema: "management",
                table: "Bookings",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Commissions_BookingId",
                schema: "management",
                table: "Commissions",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Commissions_BrokerId",
                schema: "management",
                table: "Commissions",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentId",
                schema: "web",
                table: "Menus",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentIntents_BookingId",
                schema: "management",
                table: "PaymentIntents",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentIntents_UserId",
                schema: "management",
                table: "PaymentIntents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlanMilestoneFees_MilestoneId",
                schema: "management",
                table: "PaymentPlanMilestoneFees",
                column: "MilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlanMilestones_OwnerId",
                schema: "management",
                table: "PaymentPlanMilestones",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlanMilestones_PaymentPlanId",
                schema: "management",
                table: "PaymentPlanMilestones",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlans_OwnerId",
                schema: "management",
                table: "PaymentPlans",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "PermissionNameIndex",
                schema: "core",
                table: "Permissions",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInstallmentPlan_PaymentPlanId",
                schema: "management",
                table: "ProjectInstallmentPlan",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectInstallmentPlan_ProjectId",
                schema: "management",
                table: "ProjectInstallmentPlan",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                schema: "management",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_OwnerId",
                schema: "management",
                table: "Properties",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PaymentPlanId",
                schema: "management",
                table: "Properties",
                column: "PaymentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ProjectId",
                schema: "management",
                table: "Properties",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                schema: "core",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_TransactionId",
                schema: "management",
                table: "Refunds",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                schema: "core",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                schema: "core",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "core",
                table: "Roles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PaymentIntentId",
                schema: "management",
                table: "Transactions",
                column: "PaymentIntentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                schema: "management",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivities_UserId",
                schema: "core",
                table: "UserActivities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                schema: "core",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                schema: "core",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "core",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "core",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AccountId",
                schema: "core",
                table: "Users",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ManagerId",
                schema: "core",
                table: "Users",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "core",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Bookings_BookingId",
                schema: "management",
                table: "Accounts",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_OwnerId",
                schema: "management",
                table: "Accounts",
                column: "OwnerId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Bookings_BookingId",
                schema: "management",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_OwnerId",
                schema: "management",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "AuditEntries",
                schema: "core");

            migrationBuilder.DropTable(
                name: "BookingBrokerAgents",
                schema: "management");

            migrationBuilder.DropTable(
                name: "BookingCustomers",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Commissions",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Contacts",
                schema: "management");

            migrationBuilder.DropTable(
                name: "FormLayouts",
                schema: "web");

            migrationBuilder.DropTable(
                name: "IdentityUserTokens",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Menus",
                schema: "web");

            migrationBuilder.DropTable(
                name: "PaymentPlanMilestoneFees",
                schema: "management");

            migrationBuilder.DropTable(
                name: "ProjectInstallmentPlan",
                schema: "management");

            migrationBuilder.DropTable(
                name: "RefreshTokens",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Refunds",
                schema: "management");

            migrationBuilder.DropTable(
                name: "RoleClaims",
                schema: "core");

            migrationBuilder.DropTable(
                name: "RolePermissions",
                schema: "core");

            migrationBuilder.DropTable(
                name: "UserActivities",
                schema: "core");

            migrationBuilder.DropTable(
                name: "UserClaims",
                schema: "core");

            migrationBuilder.DropTable(
                name: "UserLogins",
                schema: "core");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Audits",
                schema: "core");

            migrationBuilder.DropTable(
                name: "BookingBrokers",
                schema: "management");

            migrationBuilder.DropTable(
                name: "PaymentPlanMilestones",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Transactions",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "core");

            migrationBuilder.DropTable(
                name: "PaymentIntents",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Bookings",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Properties",
                schema: "management");

            migrationBuilder.DropTable(
                name: "PaymentPlans",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "management");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Accounts",
                schema: "management");
        }
    }
}
