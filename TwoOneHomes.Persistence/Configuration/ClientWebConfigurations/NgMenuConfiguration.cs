using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.ClientAppLayout;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.ClientWebConfigurations;

public class NgMenuConfiguration : IEntityTypeConfiguration<NgMenu>
{
    public void Configure(EntityTypeBuilder<NgMenu> builder)
    {
        builder.ToTable("Menus", "web");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Parent)
            .WithMany(x => x.Items)
            .HasForeignKey(x => x.ParentId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);


        var menus = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000FPSYZH3GPW5MSXK9"),
                Label = "Sales",
                Icon = "pi pi-fw",
                ParentId = null,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000HEJQ7G0X4875BX5W"),
                Label = "Inventory",
                Icon = "pi pi-fw",
                ParentId = null,
                Hierarchy = 1
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000775C83ZMHS46KZB9"),
                Label = "Setup",
                Icon = "pi pi-fw ",
                ParentId = null,
                Hierarchy = 4,
                CanDelete = false,
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000RYZQVQKZQSR3Y36G"),
                Label = "Profile",
                Icon = "pi pi-fw ",
                ParentId = null,
                Hierarchy = 3,
                CanDelete = false,
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000198QVPQ7XV89MJWX"),
                Label = "Finance",
                Icon = "pi pi-fw ",
                ParentId = null,
                Hierarchy = 2,
                CanDelete = false,
            },
        };

        builder.HasData(menus);

        var finances = new List<NgMenu>
        {   
            new NgMenu
            {
                Id = Ulid.Parse("0000000000WDW20YJNFXE2DTVQ"),
                Label = "Payments",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[4].Id,
                Hierarchy = 0
            }, 
            new NgMenu
            {
                Id = Ulid.Parse("0000000000CXAWCP89EXGPKECJ"),
                Label = "Transactions",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[4].Id,
                Hierarchy = 1
            },
            new NgMenu
            {
                Id = Ulid.Parse("000000000055S8J73XT725Z2CA"),
                Label = "Refunds",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[4].Id,
                Hierarchy = 2
            },
            new NgMenu
            {
                Id = Ulid.Parse("000000000088SB0BQ7Z6H7TWG8"),
                Label = "Commissions",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[4].Id,
                Hierarchy = 3
            },
        };

        builder.HasData(finances);
        
        
        
        
        var profiles = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000N5BT29EYSWKMC4QF"),
                Label = "My Profile",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[3].Id,
                RouterLinkArray = "/user/account",
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("00000000007D7QD668G6XAWGJE"),
                Label = "Account",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[3].Id,
                RouterLinkArray = "/user/account",
                Hierarchy = 1
            },
            new NgMenu
            {
                Id = Ulid.Parse("00000000000MX84X20254R1SWM"),
                Label = "Password & Security",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[3].Id,
                Hierarchy = 2
            },
        };

        builder.HasData(profiles);



        var inventories = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000QYCVEFG11KHT3GZE"),
                Label = "Projects",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[1].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000NJ1W4RE1R0D30K5Y"),
                Label = "Properties",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[1].Id,
                Hierarchy = 1
            },
            new NgMenu
            {
                Id = Ulid.Parse("00000000005WS823HSNADT1DRY"),
                Label = "PaymentPlans",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[1].Id,
                Hierarchy = 2
            },
        };

        builder.HasData(inventories);


        var projects = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000ZCNPNPHRC1X9J29F"),
                Label = "New Lead",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Projects/new",
                ParentId = inventories[0].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000EPAPEKGQS5XMA8KF"),
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Projects/list-view",
                ParentId = inventories[0].Id,
                Hierarchy = 1
            },
        };
        
        builder.HasData(projects);
        
        var properties = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("000000000010DW8BRZ9763YHKX"),
                Label = "New Lead",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Properties/new",
                ParentId = inventories[1].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000AE87ZDXB60RME616"),
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Properties/list-view",
                ParentId = inventories[1].Id,
                Hierarchy = 1
            },
        };
        
        builder.HasData(properties);
        
        var paymentPlans = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000XK6SBCD6BK2N2B5Y"),
                Label = "New Lead",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/PaymentPlans/new",
                ParentId = inventories[1].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000TTQABZX4E19BPT4M"),
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/PaymentPlans/list-view",
                ParentId = inventories[1].Id,
                Hierarchy = 1
            },
        };
        
        builder.HasData(paymentPlans);


        var sales = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("000000000065ET5P858WE44ESH"),
                Label = "Leads",
                Icon = "pi pi-fw pi-id-card",
                ParentId = menus[0].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000TMSKXZG0TQS8KH4E"),
                Label = "Contacts",
                Icon = "pi pi-fw pi-address-book",
                ParentId = menus[0].Id,
                Hierarchy = 1
            },
            new NgMenu
            {
                Id = Ulid.Parse("00000000008CPGH1XH0C8H43XB"),
                Label = "Accounts",
                Icon = "pi pi-fw pi-building",
                ParentId = menus[0].Id,
                Hierarchy = 2
            },
            new NgMenu
            {
                Id = Ulid.Parse("00000000009XWDPJSQF96B4NP7"),
                Label = "Opportunities",
                Icon = "pi pi-fw pi-bookmark",
                ParentId = menus[0].Id,
                Hierarchy = 3
            },
        };

        builder.HasData(sales);


        var leadMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("000000000010A44W9QKCDF8R01"),
                Label = "New Lead",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Leads/new",
                ParentId = sales[0].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("000000000029GN3AW98KG9NSW0"),
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Leads/list-view",
                ParentId = sales[0].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(leadMenu);


        var contactMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000B9VEPEMT33QKH8GJ"),
                Label = "New Contact",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Contacts/new",
                ParentId = sales[1].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000BY6K569JMAXKBFQ4"),
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Contacts/list-view",
                ParentId = sales[1].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(contactMenu);


        var accountMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000AA85C44J7Z6EHSK9"),
                Label = "New Account",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Accounts/new",
                ParentId = sales[2].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000ZZZNEZFA5KW8VQ49"),
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Accounts/list-view",
                ParentId = sales[2].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(accountMenu);


        var oppMenu = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000DB9RAE6NFQ7D947H"),
                Label = "New Opportunity",
                Icon = "pi pi-fw pi-plus",
                RouterLinkArray = "/r/Opportunities/new",
                ParentId = sales[3].Id,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("00000000007TXYNB9SCDNX2PBW"),
                Label = "List View",
                Icon = "pi pi-fw pi-list",
                RouterLinkArray = "/r/Opportunities/list-view",
                ParentId = sales[3].Id,
                Hierarchy = 1
            },
        };

        builder.HasData(oppMenu);


        var setup = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("00000000006D8TXH0VSKS8A16T"),
                Label = "Administrations",
                Icon = "pi pi-fw pi-users",
                ParentId = menus[2].Id,
                Hierarchy = 0,
                CanDelete = false,
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000RS4BRNHEH542PJ7C"),
                Label = "Settings",
                Icon = "pi pi-fw pi-wrench",
                ParentId = menus[2].Id,
                Hierarchy = 1,
                CanDelete = false,
            },
        };

        builder.HasData(setup);

        var administration = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("0000000000E1X6ZFQH12PK4K79"),
                Label = "Permissions",
                Icon = "pi pi-fw",
                ParentId = setup[0].Id,
                RouterLinkArray = "/setup/administrations/permission",
                Hierarchy = 0,
                CanDelete = false,
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000KZS5Z9FTHRW81DB8"),
                Label = "Roles",
                Icon = "pi pi-fw ",
                ParentId = setup[0].Id,
                RouterLinkArray = "/setup/administrations/role",
                Hierarchy = 1,
                CanDelete = false,
            },
            new NgMenu
            {
                Id = Ulid.Parse("000000000091AF12TDAYDRJWWX"),
                Label = "Users",
                Icon = "pi pi-fw ",
                ParentId = setup[0].Id,
                RouterLinkArray = "/setup/administrations/user",
                Hierarchy = 2,
                CanDelete = false,
            },
        };

        builder.HasData(administration);

        var settings = new List<NgMenu>
        {
            new NgMenu
            {
                Id = Ulid.Parse("000000000091VTD5TYNF1KWWPW"),
                Label = "Menu Settings",
                Icon = "pi pi-fw",
                ParentId = setup[1].Id,
                RouterLinkArray = "/setup/settings/menu",
                Hierarchy = 0,
                CanDelete = false,
            },
        };

        builder.HasData(settings);
    }
}