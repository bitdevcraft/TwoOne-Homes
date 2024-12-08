using System.Collections;
using TwoOneHomes.Application.Abstraction.Authorization;
using TwoOneHomes.Application.Permissions.ListPermission;
using TwoOneHomes.Domain.Shared;
using TwoOneHomes.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TwoOneHomes.Presentation.Controllers;

[Authorize]
public class PermissionController(ISender sender) : ApiController(sender)
{
    [HttpGet()]
    public async Task<IActionResult> GetPermissions()
    {
        var query = new ListPermissionQuery();
        Result<Hashtable> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }
}
