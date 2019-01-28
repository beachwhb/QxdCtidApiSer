using Abp.Authorization;
using QxdCtidApiSer.Authorization.Roles;
using QxdCtidApiSer.Authorization.Users;

namespace QxdCtidApiSer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
