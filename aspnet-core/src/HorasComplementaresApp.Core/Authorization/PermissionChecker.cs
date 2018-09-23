using Abp.Authorization;
using HorasComplementaresApp.Authorization.Roles;
using HorasComplementaresApp.Authorization.Users;

namespace HorasComplementaresApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
