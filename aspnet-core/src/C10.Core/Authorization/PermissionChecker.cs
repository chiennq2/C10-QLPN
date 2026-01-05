using Abp.Authorization;
using C10.Authorization.Roles;
using C10.Authorization.Users;

namespace C10.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
