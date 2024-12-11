using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwoOneHomes.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NewMenuData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                schema: "management",
                table: "Contacts",
                columns: new[] { "Id", "CreatedOnUtc", "Email", "FirstName", "LastName", "Mobile", "ModifiedOnUtc", "Name", "Phone" },
                values: new object[,]
                {
                    { "01JETM3W1P1MN9QPN7K0WT7H1X", new DateTime(2024, 12, 11, 10, 26, 57, 718, DateTimeKind.Utc).AddTicks(9592), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JETM3W1P3KKJHF1Y2Z23NKDR", new DateTime(2024, 12, 11, 10, 26, 57, 718, DateTimeKind.Utc).AddTicks(9586), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" },
                    { "01JETM3W1PA0S5T0A5VX901492", new DateTime(2024, 12, 11, 10, 26, 57, 718, DateTimeKind.Utc).AddTicks(9595), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" },
                    { "01JETM3W1PFJC2YMQPPYAC5SY1", new DateTime(2024, 12, 11, 10, 26, 57, 718, DateTimeKind.Utc).AddTicks(9589), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" },
                    { "01JETM3W1PTN2C5Q2VEM0GGKHW", new DateTime(2024, 12, 11, 10, 26, 57, 718, DateTimeKind.Utc).AddTicks(9577), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" }
                });

            migrationBuilder.InsertData(
                schema: "web",
                table: "Menus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "00000000005WS823HSNADT1DRY", true, 0, "pi pi-fw pi-id-card", "PaymentPlans", "0000000000HEJQ7G0X4875BX5W", "/r/PaymentPlans/list-view", null },
                    { "0000000000NJ1W4RE1R0D30K5Y", true, 0, "pi pi-fw pi-id-card", "Properties", "0000000000HEJQ7G0X4875BX5W", "/r/Properties/list-view", null },
                    { "0000000000QYCVEFG11KHT3GZE", true, 0, "pi pi-fw pi-id-card", "Projects", "0000000000HEJQ7G0X4875BX5W", "/r/Projects/list-view", null }
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "Permissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01JETM3W2J0R0MFC5E9XQC7KTW", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "01JETM3W2J196YX9QJY8HEY23R", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "01JETM3W2J2VV6GGKYB66TZVM9", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "01JETM3W2J2ZRJMV18MEWAV4E0", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "01JETM3W2J4Z54P78XG8CZKQSE", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "01JETM3W2J8GBDW37S58K0AC7D", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "01JETM3W2JDCMTB59HPHXNVVJP", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "01JETM3W2JDXEDN5H81A338XZH", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "01JETM3W2JGRXBM8A5ZMDR1D69", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "01JETM3W2JHVMDJ24YYY03Q4X2", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "01JETM3W2JTDCGQW4GPX8K30HX", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "01JETM3W2JY40RTMNZ3K0F1JCE", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETM3W1P1MN9QPN7K0WT7H1X");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETM3W1P3KKJHF1Y2Z23NKDR");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETM3W1PA0S5T0A5VX901492");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETM3W1PFJC2YMQPPYAC5SY1");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JETM3W1PTN2C5Q2VEM0GGKHW");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "00000000005WS823HSNADT1DRY");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000NJ1W4RE1R0D30K5Y");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000QYCVEFG11KHT3GZE");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2J0R0MFC5E9XQC7KTW");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2J196YX9QJY8HEY23R");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2J2VV6GGKYB66TZVM9");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2J2ZRJMV18MEWAV4E0");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2J4Z54P78XG8CZKQSE");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2J8GBDW37S58K0AC7D");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2JDCMTB59HPHXNVVJP");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2JDXEDN5H81A338XZH");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2JGRXBM8A5ZMDR1D69");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2JHVMDJ24YYY03Q4X2");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2JTDCGQW4GPX8K30HX");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "01JETM3W2JY40RTMNZ3K0F1JCE");

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
    }
}
