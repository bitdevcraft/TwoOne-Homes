﻿using TwoOneHomes.Domain.Shared.Errors;
using TwoOneHomes.Domain.Shared.Results;

namespace TwoOneHomes.Domain.Shared.Vaildations;

public sealed class ValidationResult<TValue> : Result<TValue>, IValidationResult
{
    private ValidationResult(Error[] errors)
        : base(default, false, IValidationResult.ValidationError) => Errors = errors;

    public Error[] Errors { get; }

    public static ValidationResult<TValue> WithErrors(Error[] errors) => new(errors);
}