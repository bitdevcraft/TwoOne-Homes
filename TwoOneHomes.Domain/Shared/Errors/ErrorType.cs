namespace TwoOneHomes.Domain.Shared.Errors;

public enum ErrorType
{
    None,
    Failure,
    Unexpected,
    Validation,
    Conflict,
    NotFound,
    Unauthorized,
    Forbidden,
}
