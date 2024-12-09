using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Domain.Shared.Vaildations;

public sealed class ValidationResult : Result, IValidationResult
{
    private ValidationResult(Error[] errors)
        : base(false, IValidationResult.ValidationError) => Errors = errors;

    public Error[] Errors { get; }

    public static ValidationResult WithErrors(Error[] errors) => new(errors);
}
