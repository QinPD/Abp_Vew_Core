using Abp.Authorization;
using ABP_VUE.Authorization.Roles;
using ABP_VUE.Authorization.Users;

namespace ABP_VUE.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
