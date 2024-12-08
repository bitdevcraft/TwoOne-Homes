using TwoOneHomes.Application.Abstraction.Messaging;

namespace TwoOneHomes.Application.AppMenus.DeleteNgMenu;

public record DeleteNgMenuCommand(string Id) : ICommand;