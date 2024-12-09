using System.ComponentModel.DataAnnotations;
using TwoOneHomes.Domain.Primitives;

namespace TwoOneHomes.Domain.Users.Tokens;

public class RefreshToken : Entity
{
    public new Ulid Id { get; init; } = Ulid.NewUlid();
    public required User User { get; init; }
    public Ulid? UserId { get; init; }
    [MaxLength(50)] public string? Token { get; init; }
    public DateTime Expires { get; init; } = DateTime.UtcNow.AddDays(7);
    private bool IsExpired => DateTime.UtcNow >= Expires;
    public DateTime? Revoked { get; init; }
    public bool IsUsed { get; set; }
    public bool IsActive => Revoked == null && !IsExpired && !IsUsed;
}