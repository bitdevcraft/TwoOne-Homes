using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoOneHomes.Domain.ClientAppLayout;
using TwoOneHomes.Persistence.Constants;

namespace TwoOneHomes.Persistence.Configuration.ClientWebConfigurations;

public class NgMenuConfiguration : IEntityTypeConfiguration<NgMenu>
{
    public void Configure(EntityTypeBuilder<NgMenu> builder)
    {
        builder.ToTable(TableNames.NgMenus);
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
                Icon = "pi pi-fw pi-wallet",
                ParentId = null,
                Hierarchy = 0
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000775C83ZMHS46KZB9"),
                Label = "Setup",
                Icon = "pi pi-fw pi-cog",
                ParentId = null,
                Hierarchy = 1,
                CanDelete = false,
            },
        };

        builder.HasData(menus);


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
                ParentId = menus[1].Id,
                Hierarchy = 0,
                CanDelete = false,
            },
            new NgMenu
            {
                Id = Ulid.Parse("0000000000RS4BRNHEH542PJ7C"),
                Label = "Settings",
                Icon = "pi pi-fw pi-wrench",
                ParentId = menus[1].Id,
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