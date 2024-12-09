using TwoOneHomes.Application.Abstraction.Services;
using TwoOneHomes.Domain.Emails;

namespace TwoOneHomes.Infrastructure.Services.Email;

public class EmailService : IEmailService
{
    public Task SendEmailAsync(MailRequest mailRequest, CancellationToken token = default) 
        => Task.CompletedTask;
}