using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwoOneHomes.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewMenuData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                schema: "management",
                table: "Bookings",
                type: "character varying(65535)",
                maxLength: 65535,
                nullable: true);

            migrationBuilder.InsertData(
                schema: "management",
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "FirstName", "LastName", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JETKMF9BGNJNDYGCQSSF9RDC", new DateTime(2024, 12, 11, 10, 18, 33, 131, DateTimeKind.Utc).AddTicks(8486), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" },
                    { "01JETKMF9BHN7WKZ05CPP8J5FG", new DateTime(2024, 12, 11, 10, 18, 33, 131, DateTimeKind.Utc).AddTicks(8481), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" },
                    { "01JETKMF9BM5Y3FFK9RSBCT5VR", new DateTime(2024, 12, 11, 10, 18, 33, 131, DateTimeKind.Utc).AddTicks(8493), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JETKMF9BQVMJA6K5TT7EZSQ6", new DateTime(2024, 12, 11, 10, 18, 33, 131, DateTimeKind.Utc).AddTicks(8490), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" },
                    { "01JETKMF9BWQZ26N6Q6RE1XK4Q", new DateTime(2024, 12, 11, 10, 18, 33, 131, DateTimeKind.Utc).AddTicks(8496), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" }
                });

            migrationBuilder.InsertData(
                schema: "web",
                table: "Menus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[] { "0000000000HEJQ7G0X4875BX5W", true, 0, "pi pi-fw pi-wallet", "Inventory", null, null, null });

            migrationBuilder.InsertData(
                schema: "core",
                table: "Permissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JETKMFAY07XVSV1N4YXKEHCC", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JETKMFAY30BXAZWPP529Y0XT", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JETKMFAY6G23QSRZPT5XQPTT", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JETKMFAY8FG27NRFB0MRGW29", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JETKMFAY9PP8GS6X6J9VS9TM", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JETKMFAYCN9SAYW7MCE0WFQA", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JETKMFAYG2T7NF2D3BTC8S2Q", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JETKMFAYGT6E2D2J081DVFX1", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JETKMFAYKZ0HGX5BG9AY8HBK", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JETKMFAYMKRFB8WJFSNRCJHY", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JETKMFAYQB471REA0QRNPHAZ", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "01JETKMFAYV6W365GWR0XKWMWS", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETKMF9BGNJNDYGCQSSF9RDC");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETKMF9BHN7WKZ05CPP8J5FG");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETKMF9BM5Y3FFK9RSBCT5VR");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETKMF9BQVMJA6K5TT7EZSQ6");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETKMF9BWQZ26N6Q6RE1XK4Q");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000HEJQ7G0X4875BX5W");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAY07XVSV1N4YXKEHCC");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAY30BXAZWPP529Y0XT");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAY6G23QSRZPT5XQPTT");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAY8FG27NRFB0MRGW29");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAY9PP8GS6X6J9VS9TM");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAYCN9SAYW7MCE0WFQA");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAYG2T7NF2D3BTC8S2Q");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAYGT6E2D2J081DVFX1");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAYKZ0HGX5BG9AY8HBK");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAYMKRFB8WJFSNRCJHY");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAYQB471REA0QRNPHAZ");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETKMFAYV6W365GWR0XKWMWS");

            migrationBuilder.DropColumn(
                name: "Remarks",
                schema: "management",
                table: "Bookings");

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
        }
    }
}
