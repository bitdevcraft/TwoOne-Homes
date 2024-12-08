using System.Security.Cryptography;
using TwoOneHomes.Application.Abstraction.Authentication;

namespace TwoOneHomes.Infrastructure.Security.Authentication;

public class SessionProvider : ISessionProvider
{
    public string Generate()
    {
        byte[] randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        return Convert.ToBase64String(randomNumber);
    }
}
