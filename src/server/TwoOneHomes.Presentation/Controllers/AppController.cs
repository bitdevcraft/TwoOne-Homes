using TwoOneHomes.Application.AppMenus.CreateNgMenu;
using TwoOneHomes.Application.AppMenus.DeleteNgMenu;
using TwoOneHomes.Application.AppMenus.GetNgMenu;
using TwoOneHomes.Application.AppMenus.GetNgMenuTree;
using TwoOneHomes.Domain.ClientAppLayout;
using TwoOneHomes.Domain.Shared;
using TwoOneHomes.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TwoOneHomes.Presentation.Controllers;

public class AppController(ISender sender) : ApiController(sender)
{
    [HttpGet("menu")]
    public async Task<IActionResult> GetAppMenu()
    {
        var query = new GetNgMenuQuery();
        Result<string> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok(result.Value);
    }

    [HttpGet("menuTree")]
    public async Task<IActionResult> GetAppMenuTree()
    {
        var query = new GetNgMenuTreeQuery();
        Result<string> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok(result.Value);
    }

    [HttpPost("newMenu")]
    public async Task<IActionResult> CreateNgMenu(NgMenu menu)
    {
        var query = new CreateNgMenuCommand(menu);
        Result result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok();
    }

    [HttpPost("deleteMenu/{id}")]
    public async Task<IActionResult> DeleteNgMenu(string id)
    {
        var query = new DeleteNgMenuCommand(id);
        Result result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok();
    }
}