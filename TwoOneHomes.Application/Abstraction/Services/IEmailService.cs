using TwoOneHomes.Domain.Emails;

namespace TwoOneHomes.Application.Abstraction.Services;

public interface IEmailService
{
    Task SendEmailAsync(MailRequest mailRequest, CancellationToken token = default);
}