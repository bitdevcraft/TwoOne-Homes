using TwoOneHomes.Application.Abstraction.Messaging;
using TwoOneHomes.Domain.ClientAppLayout;

namespace TwoOneHomes.Application.AppMenus.CreateNgMenu;

public record CreateNgMenuCommand(NgMenu Menu) : ICommand;