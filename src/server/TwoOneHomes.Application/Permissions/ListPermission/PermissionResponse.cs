using System.Collections;

namespace TwoOneHomes.Application.Permissions.ListPermission;

public class PermissionResponse
{
    public required string ObjectName { get; set; }
    public Hashtable Permissions { get; set; } = [];
}
