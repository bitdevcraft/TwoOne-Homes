using TwoOneHomes.Application.Contacts.CreateContact;
using TwoOneHomes.Application.Contacts.DeleteContactById;
using TwoOneHomes.Application.Contacts.GetContactById;
using TwoOneHomes.Application.Contacts.ListContact;
using TwoOneHomes.Application.Contacts.UpdateContactById;
using TwoOneHomes.Domain.Entities;
using TwoOneHomes.Domain.Shared;
using TwoOneHomes.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TwoOneHomes.Presentation.Controllers;

public class ContactController(ISender sender) : ApiController(sender)
{
    [HttpGet()]
    public async Task<IActionResult> GetContacts()
    {
        var query = new ListContactQuery();
        Result<List<Contact>> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetContactById(string Id)
    {
        var query = new GetContactByIdQuery(Ulid.Parse(Id));
        Result<Contact> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPost()]
    public async Task<IActionResult> RegisterContact(Contact contact)
    {
        var query = new RegisterContactCommand(contact);
        Result<Ulid> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok(result.Value);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateContact(string id, Contact contact)
    {
        var query = new UpdateContactByIdCommand(Ulid.Parse(id), contact);
        Result<Unit> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContact(string id)
    {
        var query = new DeleteContactByIdCommand(Ulid.Parse(id));
        Result<Unit> result = await _sender.Send(query);

        if (result.IsFailure)
        {
            return HandleFailure(result);
        }

        return Ok();
    }
}