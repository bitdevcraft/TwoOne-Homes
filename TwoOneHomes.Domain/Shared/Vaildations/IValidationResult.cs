using TwoOneHomes.Domain.Shared.Errors;

namespace TwoOneHomes.Domain.Shared.Vaildations;

public interface IValidationResult
{
    public static readonly Error ValidationError = Error.Validation();
    Error[] Errors { get; }
}
