using TwoOneHomes.Application.Users;
using TwoOneHomes.Application.Users.CreateUser;
using TwoOneHomes.Application.Users.ListUser;
using TwoOneHomes.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Presentation.Controllers;

public class UserController(ISender sender) : ApiController(sender)
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateNewUser([FromBody] UserDto user)
    {
        var query = new CreateUserCommand(user);
        Result<Unit> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetUserList()
    {
        var query = new ListUserQuery();
        Result<List<UserListDto>> result = await _sender.Send(query);

        return result.IsFailure ? HandleFailure(result) : Ok(result.Value);
    }
}