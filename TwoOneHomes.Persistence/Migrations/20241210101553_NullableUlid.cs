using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwoOneHomes.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NullableUlid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokerAgents_BookingBrokers_BookingBrokerId",
                schema: "management",
                table: "BookingBrokerAgents");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokerAgents_Users_UserId",
                schema: "management",
                table: "BookingBrokerAgents");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokers_Accounts_AccountId",
                schema: "management",
                table: "BookingBrokers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokers_Bookings_BookingId",
                schema: "management",
                table: "BookingBrokers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingCustomers_Bookings_BookingId",
                schema: "management",
                table: "BookingCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingCustomers_Users_UserId",
                schema: "management",
                table: "BookingCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Accounts_OwnerId",
                schema: "management",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Commissions_Accounts_BrokerId",
                schema: "management",
                table: "Commissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Commissions_Bookings_BookingId",
                schema: "management",
                table: "Commissions");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentIntents_Bookings_BookingId",
                schema: "management",
                table: "PaymentIntents");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentIntents_Users_UserId",
                schema: "management",
                table: "PaymentIntents");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlanMilestoneFees_PaymentPlanMilestones_MilestoneId",
                schema: "management",
                table: "PaymentPlanMilestoneFees");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlanMilestones_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlanMilestones");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlanMilestones_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "PaymentPlanMilestones");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlans_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Accounts_OwnerId",
                schema: "management",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Accounts_OwnerId",
                schema: "management",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Projects_ProjectId",
                schema: "management",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_Transactions_TransactionId",
                schema: "management",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_PaymentIntents_PaymentIntentId",
                schema: "management",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserId",
                schema: "management",
                table: "Transactions");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEQZTJ942533C2F0WEXHCXDS");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEQZTJ946XNWYTX0DZQR3CSJ");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEQZTJ94FXG50W9X39TS2PZW");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEQZTJ94H538GXPJCETJWHE8");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEQZTJ94QJDSXR4QYFXX271C");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9K28MW4FDPKWQN8ZCY");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9K2G11138YC7TJZ245");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9K34NMM6BGAWPDAQT9");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9K52M7C25RHPPW42DR");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9K5X6M4XE2D7DKXBTQ");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9K5XJNDWC5T8DKSTMJ");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9K96E1BRQQG036QSGG");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9KDZPW4TYN4ZNH7DF7");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9KGWXBPX52HF6Q4J5C");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9KNJ4C6E9PQGFR2RQ3");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9KW5NJRZ5WHASAKAWJ");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JEQZTJ9KZDJFFPQYKK0GYW14");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                schema: "core",
                table: "Users",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "Transactions",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                schema: "management",
                table: "Transactions",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                schema: "management",
                table: "Refunds",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                schema: "management",
                table: "Properties",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentPlanId",
                schema: "management",
                table: "Properties",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "Properties",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "Projects",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                schema: "management",
                table: "ProjectInstallmentPlan",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentPlanId",
                schema: "management",
                table: "ProjectInstallmentPlan",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "PaymentPlans",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "PaymentPlanId",
                schema: "management",
                table: "PaymentPlanMilestones",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "PaymentPlanMilestones",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "MilestoneId",
                schema: "management",
                table: "PaymentPlanMilestoneFees",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "PaymentIntents",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "PaymentIntents",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "BrokerId",
                schema: "management",
                table: "Commissions",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "Commissions",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "PropertyId",
                schema: "management",
                table: "Bookings",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "Bookings",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "MainCustomerId",
                schema: "management",
                table: "Bookings",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "BookingCustomers",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "BookingCustomers",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "BookingBrokers",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                schema: "management",
                table: "BookingBrokers",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "BookingBrokerAgents",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "BookingBrokerId",
                schema: "management",
                table: "BookingBrokerAgents",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "RecordId",
                schema: "core",
                table: "Audits",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.AlterColumn<string>(
                name: "ParentAccountId",
                schema: "management",
                table: "Accounts",
                type: "character varying(26)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(26)");

            migrationBuilder.InsertData(
                schema: "management",
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "FirstName", "LastName", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JER12VBX0684JB3SRE6P3NV6", new DateTime(2024, 12, 10, 10, 15, 52, 445, DateTimeKind.Utc).AddTicks(7456), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JER12VBX9Q2QRYEXA8PGDGYT", new DateTime(2024, 12, 10, 10, 15, 52, 445, DateTimeKind.Utc).AddTicks(7445), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" },
                    { "01JER12VBX9QZP33HZHKZBXDDX", new DateTime(2024, 12, 10, 10, 15, 52, 445, DateTimeKind.Utc).AddTicks(7459), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" },
                    { "01JER12VBXFVBWMWSMC9S6WNP6", new DateTime(2024, 12, 10, 10, 15, 52, 445, DateTimeKind.Utc).AddTicks(7453), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" },
                    { "01JER12VBXKZVG7YH431419QSN", new DateTime(2024, 12, 10, 10, 15, 52, 445, DateTimeKind.Utc).AddTicks(7450), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" }
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "Permissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JER12VCD11VB20G92MAD5ZJB", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JER12VCD15ZB8B7BYP9J3WAF", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JER12VCD1X42GRZW9461T0SA", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JER12VCD2V2V3NK6H4SGZPVK", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JER12VCD31SPED1FW7N6Z5ZD", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JER12VCD3JFD9NVGM246GVEJ", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JER12VCD98RC1WN08P3Y4MXH", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JER12VCDC08F0AEH7NY5BNC2", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JER12VCDCHEH7FYYB4X1NT9Z", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JER12VCDQS1B15EVX1SYK1PB", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JER12VCDTC8JZDZAA8HQ9HF7", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JER12VCDYT48Y6CGRXQG314Q", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokerAgents_BookingBrokers_BookingBrokerId",
                schema: "management",
                table: "BookingBrokerAgents",
                column: "BookingBrokerId",
                principalSchema: "management",
                principalTable: "BookingBrokers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokerAgents_Users_UserId",
                schema: "management",
                table: "BookingBrokerAgents",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokers_Accounts_AccountId",
                schema: "management",
                table: "BookingBrokers",
                column: "AccountId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokers_Bookings_BookingId",
                schema: "management",
                table: "BookingBrokers",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCustomers_Bookings_BookingId",
                schema: "management",
                table: "BookingCustomers",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCustomers_Users_UserId",
                schema: "management",
                table: "BookingCustomers",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Accounts_OwnerId",
                schema: "management",
                table: "Bookings",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commissions_Accounts_BrokerId",
                schema: "management",
                table: "Commissions",
                column: "BrokerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Commissions_Bookings_BookingId",
                schema: "management",
                table: "Commissions",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentIntents_Bookings_BookingId",
                schema: "management",
                table: "PaymentIntents",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentIntents_Users_UserId",
                schema: "management",
                table: "PaymentIntents",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlanMilestoneFees_PaymentPlanMilestones_MilestoneId",
                schema: "management",
                table: "PaymentPlanMilestoneFees",
                column: "MilestoneId",
                principalSchema: "management",
                principalTable: "PaymentPlanMilestones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlanMilestones_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlanMilestones",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlanMilestones_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "PaymentPlanMilestones",
                column: "PaymentPlanId",
                principalSchema: "management",
                principalTable: "PaymentPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlans_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlans",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Accounts_OwnerId",
                schema: "management",
                table: "Projects",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Accounts_OwnerId",
                schema: "management",
                table: "Properties",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "Properties",
                column: "PaymentPlanId",
                principalSchema: "management",
                principalTable: "PaymentPlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Projects_ProjectId",
                schema: "management",
                table: "Properties",
                column: "ProjectId",
                principalSchema: "management",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_Transactions_TransactionId",
                schema: "management",
                table: "Refunds",
                column: "TransactionId",
                principalSchema: "management",
                principalTable: "Transactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_PaymentIntents_PaymentIntentId",
                schema: "management",
                table: "Transactions",
                column: "PaymentIntentId",
                principalSchema: "management",
                principalTable: "PaymentIntents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserId",
                schema: "management",
                table: "Transactions",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokerAgents_BookingBrokers_BookingBrokerId",
                schema: "management",
                table: "BookingBrokerAgents");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokerAgents_Users_UserId",
                schema: "management",
                table: "BookingBrokerAgents");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokers_Accounts_AccountId",
                schema: "management",
                table: "BookingBrokers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingBrokers_Bookings_BookingId",
                schema: "management",
                table: "BookingBrokers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingCustomers_Bookings_BookingId",
                schema: "management",
                table: "BookingCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingCustomers_Users_UserId",
                schema: "management",
                table: "BookingCustomers");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Accounts_OwnerId",
                schema: "management",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Commissions_Accounts_BrokerId",
                schema: "management",
                table: "Commissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Commissions_Bookings_BookingId",
                schema: "management",
                table: "Commissions");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentIntents_Bookings_BookingId",
                schema: "management",
                table: "PaymentIntents");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentIntents_Users_UserId",
                schema: "management",
                table: "PaymentIntents");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlanMilestoneFees_PaymentPlanMilestones_MilestoneId",
                schema: "management",
                table: "PaymentPlanMilestoneFees");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlanMilestones_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlanMilestones");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlanMilestones_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "PaymentPlanMilestones");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlans_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Accounts_OwnerId",
                schema: "management",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Accounts_OwnerId",
                schema: "management",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Projects_ProjectId",
                schema: "management",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_Transactions_TransactionId",
                schema: "management",
                table: "Refunds");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_PaymentIntents_PaymentIntentId",
                schema: "management",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserId",
                schema: "management",
                table: "Transactions");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JER12VBX0684JB3SRE6P3NV6");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JER12VBX9Q2QRYEXA8PGDGYT");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JER12VBX9QZP33HZHKZBXDDX");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JER12VBXFVBWMWSMC9S6WNP6");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JER12VBXKZVG7YH431419QSN");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCD11VB20G92MAD5ZJB");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCD15ZB8B7BYP9J3WAF");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCD1X42GRZW9461T0SA");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCD2V2V3NK6H4SGZPVK");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCD31SPED1FW7N6Z5ZD");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCD3JFD9NVGM246GVEJ");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCD98RC1WN08P3Y4MXH");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCDC08F0AEH7NY5BNC2");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCDCHEH7FYYB4X1NT9Z");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCDQS1B15EVX1SYK1PB");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCDTC8JZDZAA8HQ9HF7");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JER12VCDYT48Y6CGRXQG314Q");

            migrationBuilder.AlterColumn<string>(
                name: "ManagerId",
                schema: "core",
                table: "Users",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "Transactions",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentIntentId",
                schema: "management",
                table: "Transactions",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionId",
                schema: "management",
                table: "Refunds",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                schema: "management",
                table: "Properties",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentPlanId",
                schema: "management",
                table: "Properties",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "Properties",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "Projects",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                schema: "management",
                table: "ProjectInstallmentPlan",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentPlanId",
                schema: "management",
                table: "ProjectInstallmentPlan",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "PaymentPlans",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PaymentPlanId",
                schema: "management",
                table: "PaymentPlanMilestones",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "PaymentPlanMilestones",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MilestoneId",
                schema: "management",
                table: "PaymentPlanMilestoneFees",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "PaymentIntents",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "PaymentIntents",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrokerId",
                schema: "management",
                table: "Commissions",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "Commissions",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PropertyId",
                schema: "management",
                table: "Bookings",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                schema: "management",
                table: "Bookings",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MainCustomerId",
                schema: "management",
                table: "Bookings",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "BookingCustomers",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "BookingCustomers",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingId",
                schema: "management",
                table: "BookingBrokers",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountId",
                schema: "management",
                table: "BookingBrokers",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                schema: "management",
                table: "BookingBrokerAgents",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingBrokerId",
                schema: "management",
                table: "BookingBrokerAgents",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RecordId",
                schema: "core",
                table: "Audits",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParentAccountId",
                schema: "management",
                table: "Accounts",
                type: "character varying(26)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(26)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokerAgents_BookingBrokers_BookingBrokerId",
                schema: "management",
                table: "BookingBrokerAgents",
                column: "BookingBrokerId",
                principalSchema: "management",
                principalTable: "BookingBrokers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokerAgents_Users_UserId",
                schema: "management",
                table: "BookingBrokerAgents",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokers_Accounts_AccountId",
                schema: "management",
                table: "BookingBrokers",
                column: "AccountId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingBrokers_Bookings_BookingId",
                schema: "management",
                table: "BookingBrokers",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCustomers_Bookings_BookingId",
                schema: "management",
                table: "BookingCustomers",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingCustomers_Users_UserId",
                schema: "management",
                table: "BookingCustomers",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Accounts_OwnerId",
                schema: "management",
                table: "Bookings",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commissions_Accounts_BrokerId",
                schema: "management",
                table: "Commissions",
                column: "BrokerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commissions_Bookings_BookingId",
                schema: "management",
                table: "Commissions",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentIntents_Bookings_BookingId",
                schema: "management",
                table: "PaymentIntents",
                column: "BookingId",
                principalSchema: "management",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentIntents_Users_UserId",
                schema: "management",
                table: "PaymentIntents",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlanMilestoneFees_PaymentPlanMilestones_MilestoneId",
                schema: "management",
                table: "PaymentPlanMilestoneFees",
                column: "MilestoneId",
                principalSchema: "management",
                principalTable: "PaymentPlanMilestones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlanMilestones_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlanMilestones",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlanMilestones_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "PaymentPlanMilestones",
                column: "PaymentPlanId",
                principalSchema: "management",
                principalTable: "PaymentPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlans_Accounts_OwnerId",
                schema: "management",
                table: "PaymentPlans",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Accounts_OwnerId",
                schema: "management",
                table: "Projects",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Accounts_OwnerId",
                schema: "management",
                table: "Properties",
                column: "OwnerId",
                principalSchema: "management",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PaymentPlans_PaymentPlanId",
                schema: "management",
                table: "Properties",
                column: "PaymentPlanId",
                principalSchema: "management",
                principalTable: "PaymentPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Projects_ProjectId",
                schema: "management",
                table: "Properties",
                column: "ProjectId",
                principalSchema: "management",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_Transactions_TransactionId",
                schema: "management",
                table: "Refunds",
                column: "TransactionId",
                principalSchema: "management",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_PaymentIntents_PaymentIntentId",
                schema: "management",
                table: "Transactions",
                column: "PaymentIntentId",
                principalSchema: "management",
                principalTable: "PaymentIntents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserId",
                schema: "management",
                table: "Transactions",
                column: "UserId",
                principalSchema: "core",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
