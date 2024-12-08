
namespace TwoOneHomes.Application.Abstraction.Authentication;

public interface IRefreshTokenProvider
{
    string GenerateRefreshToken();
}