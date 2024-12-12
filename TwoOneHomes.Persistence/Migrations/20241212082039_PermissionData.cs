using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TwoOneHomes.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PermissionData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "01JEWZ99FK86GW34J2WC3BWXM4", new DateTime(2024, 12, 12, 8, 20, 38, 515, DateTimeKind.Utc).AddTicks(1470), "jane.smith@example.com", null, null, "+987654321", null, "Jane Smith", "+123456789" },
                    { "01JEWZ99FKJYRENJ4XBP2H6X8H", new DateTime(2024, 12, 12, 8, 20, 38, 515, DateTimeKind.Utc).AddTicks(1480), "charlie.davis@example.com", null, null, "+789012345", null, "Charlie Davis", "+321654987" },
                    { "01JEWZ99FKQ3VJTGT7GRNWRR04", new DateTime(2024, 12, 12, 8, 20, 38, 515, DateTimeKind.Utc).AddTicks(1474), "alice.brown@example.com", null, null, "+1029384756", null, "Alice Brown", "+5647382910" },
                    { "01JEWZ99FKRWKEB5Q2VNGA0V1T", new DateTime(2024, 12, 12, 8, 20, 38, 515, DateTimeKind.Utc).AddTicks(1477), "bob.johnson@example.com", null, null, "+567890123", null, "Bob Johnson", "+210987654" },
                    { "01JEWZ99FKWF6QVHYJWT4EHJ46", new DateTime(2024, 12, 12, 8, 20, 38, 515, DateTimeKind.Utc).AddTicks(1465), "john.doe@example.com", null, null, "+123456789", null, "John Doe", "+987654321" }
                });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "00000000005WS823HSNADT1DRY",
                columns: new[] { "Hierarchy", "RouterLinkArray" },
                values: new object[] { 2, null });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000775C83ZMHS46KZB9",
                columns: new[] { "Hierarchy", "Icon" },
                values: new object[] { 4, "pi pi-fw " });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000FPSYZH3GPW5MSXK9",
                column: "Icon",
                value: "pi pi-fw");

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000HEJQ7G0X4875BX5W",
                columns: new[] { "Hierarchy", "Icon" },
                values: new object[] { 1, "pi pi-fw" });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000NJ1W4RE1R0D30K5Y",
                columns: new[] { "Hierarchy", "RouterLinkArray" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000QYCVEFG11KHT3GZE",
                column: "RouterLinkArray",
                value: null);

            migrationBuilder.InsertData(
                schema: "web",
                table: "Menus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "000000000010DW8BRZ9763YHKX", true, 0, "pi pi-fw pi-plus", "New Lead", "0000000000NJ1W4RE1R0D30K5Y", "/r/Properties/new", null },
                    { "0000000000198QVPQ7XV89MJWX", false, 2, "pi pi-fw ", "Finance", null, null, null },
                    { "0000000000AE87ZDXB60RME616", true, 1, "pi pi-fw pi-list", "List View", "0000000000NJ1W4RE1R0D30K5Y", "/r/Properties/list-view", null },
                    { "0000000000EPAPEKGQS5XMA8KF", true, 1, "pi pi-fw pi-list", "List View", "0000000000QYCVEFG11KHT3GZE", "/r/Projects/list-view", null },
                    { "0000000000RYZQVQKZQSR3Y36G", false, 3, "pi pi-fw ", "Profile", null, null, null },
                    { "0000000000TTQABZX4E19BPT4M", true, 1, "pi pi-fw pi-list", "List View", "0000000000NJ1W4RE1R0D30K5Y", "/r/PaymentPlans/list-view", null },
                    { "0000000000XK6SBCD6BK2N2B5Y", true, 0, "pi pi-fw pi-plus", "New Lead", "0000000000NJ1W4RE1R0D30K5Y", "/r/PaymentPlans/new", null },
                    { "0000000000ZCNPNPHRC1X9J29F", true, 0, "pi pi-fw pi-plus", "New Lead", "0000000000QYCVEFG11KHT3GZE", "/r/Projects/new", null }
                });

            migrationBuilder.InsertData(
                schema: "core",
                table: "Permissions",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0000000000000000000000PRM0", null, "Permissions.Contacts.Create", "PERMISSIONS.CONTACTS.CREATE" },
                    { "0000000000000000000000PRM1", null, "Permissions.Contacts.View", "PERMISSIONS.CONTACTS.VIEW" },
                    { "0000000000000000000000PRM2", null, "Permissions.Contacts.Edit", "PERMISSIONS.CONTACTS.EDIT" },
                    { "0000000000000000000000PRM3", null, "Permissions.Contacts.Delete", "PERMISSIONS.CONTACTS.DELETE" },
                    { "0000000000000000000000PRM4", null, "Permissions.Roles.Create", "PERMISSIONS.ROLES.CREATE" },
                    { "0000000000000000000000PRM5", null, "Permissions.Roles.View", "PERMISSIONS.ROLES.VIEW" },
                    { "0000000000000000000000PRM6", null, "Permissions.Roles.Edit", "PERMISSIONS.ROLES.EDIT" },
                    { "0000000000000000000000PRM7", null, "Permissions.Roles.Delete", "PERMISSIONS.ROLES.DELETE" },
                    { "0000000000000000000000PRM8", null, "Permissions.Permissions.Create", "PERMISSIONS.PERMISSIONS.CREATE" },
                    { "0000000000000000000000PRM9", null, "Permissions.Permissions.View", "PERMISSIONS.PERMISSIONS.VIEW" },
                    { "000000000000000000000PRM10", null, "Permissions.Permissions.Edit", "PERMISSIONS.PERMISSIONS.EDIT" },
                    { "000000000000000000000PRM11", null, "Permissions.Permissions.Delete", "PERMISSIONS.PERMISSIONS.DELETE" },
                    { "000000000000000000000PRM12", null, "Permissions.Users.Create", "PERMISSIONS.USERS.CREATE" },
                    { "000000000000000000000PRM13", null, "Permissions.Users.View", "PERMISSIONS.USERS.VIEW" },
                    { "000000000000000000000PRM14", null, "Permissions.Users.Edit", "PERMISSIONS.USERS.EDIT" },
                    { "000000000000000000000PRM15", null, "Permissions.Users.Delete", "PERMISSIONS.USERS.DELETE" },
                    { "000000000000000000000PRM16", null, "Permissions.NgMenus.Create", "PERMISSIONS.NGMENUS.CREATE" },
                    { "000000000000000000000PRM17", null, "Permissions.NgMenus.View", "PERMISSIONS.NGMENUS.VIEW" },
                    { "000000000000000000000PRM18", null, "Permissions.NgMenus.Edit", "PERMISSIONS.NGMENUS.EDIT" },
                    { "000000000000000000000PRM19", null, "Permissions.NgMenus.Delete", "PERMISSIONS.NGMENUS.DELETE" },
                    { "000000000000000000000PRM20", null, "Permissions.Accounts.Create", "PERMISSIONS.ACCOUNTS.CREATE" },
                    { "000000000000000000000PRM21", null, "Permissions.Accounts.View", "PERMISSIONS.ACCOUNTS.VIEW" },
                    { "000000000000000000000PRM22", null, "Permissions.Accounts.Edit", "PERMISSIONS.ACCOUNTS.EDIT" },
                    { "000000000000000000000PRM23", null, "Permissions.Accounts.Delete", "PERMISSIONS.ACCOUNTS.DELETE" },
                    { "000000000000000000000PRM24", null, "Permissions.Bookings.Create", "PERMISSIONS.BOOKINGS.CREATE" },
                    { "000000000000000000000PRM25", null, "Permissions.Bookings.View", "PERMISSIONS.BOOKINGS.VIEW" },
                    { "000000000000000000000PRM26", null, "Permissions.Bookings.Edit", "PERMISSIONS.BOOKINGS.EDIT" },
                    { "000000000000000000000PRM27", null, "Permissions.Bookings.Delete", "PERMISSIONS.BOOKINGS.DELETE" },
                    { "000000000000000000000PRM28", null, "Permissions.BookingBrokers.Create", "PERMISSIONS.BOOKINGBROKERS.CREATE" },
                    { "000000000000000000000PRM29", null, "Permissions.BookingBrokers.View", "PERMISSIONS.BOOKINGBROKERS.VIEW" },
                    { "000000000000000000000PRM30", null, "Permissions.BookingBrokers.Edit", "PERMISSIONS.BOOKINGBROKERS.EDIT" },
                    { "000000000000000000000PRM31", null, "Permissions.BookingBrokers.Delete", "PERMISSIONS.BOOKINGBROKERS.DELETE" },
                    { "000000000000000000000PRM32", null, "Permissions.BookingAgents.Create", "PERMISSIONS.BOOKINGAGENTS.CREATE" },
                    { "000000000000000000000PRM33", null, "Permissions.BookingAgents.View", "PERMISSIONS.BOOKINGAGENTS.VIEW" },
                    { "000000000000000000000PRM34", null, "Permissions.BookingAgents.Edit", "PERMISSIONS.BOOKINGAGENTS.EDIT" },
                    { "000000000000000000000PRM35", null, "Permissions.BookingAgents.Delete", "PERMISSIONS.BOOKINGAGENTS.DELETE" },
                    { "000000000000000000000PRM36", null, "Permissions.BookingCustomers.Create", "PERMISSIONS.BOOKINGCUSTOMERS.CREATE" },
                    { "000000000000000000000PRM37", null, "Permissions.BookingCustomers.View", "PERMISSIONS.BOOKINGCUSTOMERS.VIEW" },
                    { "000000000000000000000PRM38", null, "Permissions.BookingCustomers.Edit", "PERMISSIONS.BOOKINGCUSTOMERS.EDIT" },
                    { "000000000000000000000PRM39", null, "Permissions.BookingCustomers.Delete", "PERMISSIONS.BOOKINGCUSTOMERS.DELETE" },
                    { "000000000000000000000PRM40", null, "Permissions.Commissions.Create", "PERMISSIONS.COMMISSIONS.CREATE" },
                    { "000000000000000000000PRM41", null, "Permissions.Commissions.View", "PERMISSIONS.COMMISSIONS.VIEW" },
                    { "000000000000000000000PRM42", null, "Permissions.Commissions.Edit", "PERMISSIONS.COMMISSIONS.EDIT" },
                    { "000000000000000000000PRM43", null, "Permissions.Commissions.Delete", "PERMISSIONS.COMMISSIONS.DELETE" },
                    { "000000000000000000000PRM44", null, "Permissions.PaymentIntents.Create", "PERMISSIONS.PAYMENTINTENTS.CREATE" },
                    { "000000000000000000000PRM45", null, "Permissions.PaymentIntents.View", "PERMISSIONS.PAYMENTINTENTS.VIEW" },
                    { "000000000000000000000PRM46", null, "Permissions.PaymentIntents.Edit", "PERMISSIONS.PAYMENTINTENTS.EDIT" },
                    { "000000000000000000000PRM47", null, "Permissions.PaymentIntents.Delete", "PERMISSIONS.PAYMENTINTENTS.DELETE" },
                    { "000000000000000000000PRM48", null, "Permissions.Refunds.Create", "PERMISSIONS.REFUNDS.CREATE" },
                    { "000000000000000000000PRM49", null, "Permissions.Refunds.View", "PERMISSIONS.REFUNDS.VIEW" },
                    { "000000000000000000000PRM50", null, "Permissions.Refunds.Edit", "PERMISSIONS.REFUNDS.EDIT" },
                    { "000000000000000000000PRM51", null, "Permissions.Refunds.Delete", "PERMISSIONS.REFUNDS.DELETE" },
                    { "000000000000000000000PRM52", null, "Permissions.Transactions.Create", "PERMISSIONS.TRANSACTIONS.CREATE" },
                    { "000000000000000000000PRM53", null, "Permissions.Transactions.View", "PERMISSIONS.TRANSACTIONS.VIEW" },
                    { "000000000000000000000PRM54", null, "Permissions.Transactions.Edit", "PERMISSIONS.TRANSACTIONS.EDIT" },
                    { "000000000000000000000PRM55", null, "Permissions.Transactions.Delete", "PERMISSIONS.TRANSACTIONS.DELETE" },
                    { "000000000000000000000PRM56", null, "Permissions.PaymentPlans.Create", "PERMISSIONS.PAYMENTPLANS.CREATE" },
                    { "000000000000000000000PRM57", null, "Permissions.PaymentPlans.View", "PERMISSIONS.PAYMENTPLANS.VIEW" },
                    { "000000000000000000000PRM58", null, "Permissions.PaymentPlans.Edit", "PERMISSIONS.PAYMENTPLANS.EDIT" },
                    { "000000000000000000000PRM59", null, "Permissions.PaymentPlans.Delete", "PERMISSIONS.PAYMENTPLANS.DELETE" },
                    { "000000000000000000000PRM60", null, "Permissions.PaymentPlanMilestones.Create", "PERMISSIONS.PAYMENTPLANMILESTONES.CREATE" },
                    { "000000000000000000000PRM61", null, "Permissions.PaymentPlanMilestones.View", "PERMISSIONS.PAYMENTPLANMILESTONES.VIEW" },
                    { "000000000000000000000PRM62", null, "Permissions.PaymentPlanMilestones.Edit", "PERMISSIONS.PAYMENTPLANMILESTONES.EDIT" },
                    { "000000000000000000000PRM63", null, "Permissions.PaymentPlanMilestones.Delete", "PERMISSIONS.PAYMENTPLANMILESTONES.DELETE" },
                    { "000000000000000000000PRM64", null, "Permissions.PaymentPlanMilestoneFees.Create", "PERMISSIONS.PAYMENTPLANMILESTONEFEES.CREATE" },
                    { "000000000000000000000PRM65", null, "Permissions.PaymentPlanMilestoneFees.View", "PERMISSIONS.PAYMENTPLANMILESTONEFEES.VIEW" },
                    { "000000000000000000000PRM66", null, "Permissions.PaymentPlanMilestoneFees.Edit", "PERMISSIONS.PAYMENTPLANMILESTONEFEES.EDIT" },
                    { "000000000000000000000PRM67", null, "Permissions.PaymentPlanMilestoneFees.Delete", "PERMISSIONS.PAYMENTPLANMILESTONEFEES.DELETE" },
                    { "000000000000000000000PRM68", null, "Permissions.Projects.Create", "PERMISSIONS.PROJECTS.CREATE" },
                    { "000000000000000000000PRM69", null, "Permissions.Projects.View", "PERMISSIONS.PROJECTS.VIEW" },
                    { "000000000000000000000PRM70", null, "Permissions.Projects.Edit", "PERMISSIONS.PROJECTS.EDIT" },
                    { "000000000000000000000PRM71", null, "Permissions.Projects.Delete", "PERMISSIONS.PROJECTS.DELETE" },
                    { "000000000000000000000PRM72", null, "Permissions.ProjectInstallmentPlans.Create", "PERMISSIONS.PROJECTINSTALLMENTPLANS.CREATE" },
                    { "000000000000000000000PRM73", null, "Permissions.ProjectInstallmentPlans.View", "PERMISSIONS.PROJECTINSTALLMENTPLANS.VIEW" },
                    { "000000000000000000000PRM74", null, "Permissions.ProjectInstallmentPlans.Edit", "PERMISSIONS.PROJECTINSTALLMENTPLANS.EDIT" },
                    { "000000000000000000000PRM75", null, "Permissions.ProjectInstallmentPlans.Delete", "PERMISSIONS.PROJECTINSTALLMENTPLANS.DELETE" },
                    { "000000000000000000000PRM76", null, "Permissions.Properties.Create", "PERMISSIONS.PROPERTIES.CREATE" },
                    { "000000000000000000000PRM77", null, "Permissions.Properties.View", "PERMISSIONS.PROPERTIES.VIEW" },
                    { "000000000000000000000PRM78", null, "Permissions.Properties.Edit", "PERMISSIONS.PROPERTIES.EDIT" },
                    { "000000000000000000000PRM79", null, "Permissions.Properties.Delete", "PERMISSIONS.PROPERTIES.DELETE" }
                });

            migrationBuilder.InsertData(
                schema: "web",
                table: "Menus",
                columns: new[] { "Id", "CanDelete", "Hierarchy", "Icon", "Label", "ParentId", "RouterLinkArray", "UrlArray" },
                values: new object[,]
                {
                    { "00000000000MX84X20254R1SWM", true, 2, "pi pi-fw pi-id-card", "Password & Security", "0000000000RYZQVQKZQSR3Y36G", null, null },
                    { "000000000055S8J73XT725Z2CA", true, 2, "pi pi-fw pi-id-card", "Refunds", "0000000000198QVPQ7XV89MJWX", null, null },
                    { "00000000007D7QD668G6XAWGJE", true, 1, "pi pi-fw pi-id-card", "Account", "0000000000RYZQVQKZQSR3Y36G", "/user/account", null },
                    { "000000000088SB0BQ7Z6H7TWG8", true, 3, "pi pi-fw pi-id-card", "Commissions", "0000000000198QVPQ7XV89MJWX", null, null },
                    { "0000000000CXAWCP89EXGPKECJ", true, 1, "pi pi-fw pi-id-card", "Transactions", "0000000000198QVPQ7XV89MJWX", null, null },
                    { "0000000000N5BT29EYSWKMC4QF", true, 0, "pi pi-fw pi-id-card", "My Profile", "0000000000RYZQVQKZQSR3Y36G", "/user/account", null },
                    { "0000000000WDW20YJNFXE2DTVQ", true, 0, "pi pi-fw pi-id-card", "Payments", "0000000000198QVPQ7XV89MJWX", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEWZ99FK86GW34J2WC3BWXM4");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEWZ99FKJYRENJ4XBP2H6X8H");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEWZ99FKQ3VJTGT7GRNWRR04");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEWZ99FKRWKEB5Q2VNGA0V1T");

            migrationBuilder.DeleteData(
                schema: "management",
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "01JEWZ99FKWF6QVHYJWT4EHJ46");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "00000000000MX84X20254R1SWM");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "000000000010DW8BRZ9763YHKX");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "000000000055S8J73XT725Z2CA");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "00000000007D7QD668G6XAWGJE");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "000000000088SB0BQ7Z6H7TWG8");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000AE87ZDXB60RME616");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000CXAWCP89EXGPKECJ");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000EPAPEKGQS5XMA8KF");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000N5BT29EYSWKMC4QF");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000TTQABZX4E19BPT4M");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000WDW20YJNFXE2DTVQ");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000XK6SBCD6BK2N2B5Y");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000ZCNPNPHRC1X9J29F");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM0");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM1");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM2");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM3");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM4");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM5");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM6");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM7");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM8");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "0000000000000000000000PRM9");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM10");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM11");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM12");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM13");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM14");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM15");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM16");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM17");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM18");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM19");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM20");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM21");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM22");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM23");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM24");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM25");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM26");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM27");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM28");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM29");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM30");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM31");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM32");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM33");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM34");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM35");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM36");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM37");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM38");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM39");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM40");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM41");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM42");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM43");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM44");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM45");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM46");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM47");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM48");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM49");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM50");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM51");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM52");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM53");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM54");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM55");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM56");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM57");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM58");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM59");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM60");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM61");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM62");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM63");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM64");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM65");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM66");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM67");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM68");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM69");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM70");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM71");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM72");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM73");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM74");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM75");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM76");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM77");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM78");

            migrationBuilder.DeleteData(
                schema: "core",
                table: "Permissions",
                keyColumn: "Id",
                keyValue: "000000000000000000000PRM79");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000198QVPQ7XV89MJWX");

            migrationBuilder.DeleteData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000RYZQVQKZQSR3Y36G");

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

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "00000000005WS823HSNADT1DRY",
                columns: new[] { "Hierarchy", "RouterLinkArray" },
                values: new object[] { 0, "/r/PaymentPlans/list-view" });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000775C83ZMHS46KZB9",
                columns: new[] { "Hierarchy", "Icon" },
                values: new object[] { 1, "pi pi-fw pi-cog" });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000FPSYZH3GPW5MSXK9",
                column: "Icon",
                value: "pi pi-fw pi-wallet");

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000HEJQ7G0X4875BX5W",
                columns: new[] { "Hierarchy", "Icon" },
                values: new object[] { 0, "pi pi-fw pi-wallet" });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000NJ1W4RE1R0D30K5Y",
                columns: new[] { "Hierarchy", "RouterLinkArray" },
                values: new object[] { 0, "/r/Properties/list-view" });

            migrationBuilder.UpdateData(
                schema: "web",
                table: "Menus",
                keyColumn: "Id",
                keyValue: "0000000000QYCVEFG11KHT3GZE",
                column: "RouterLinkArray",
                value: "/r/Projects/list-view");

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
    }
}
