using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HorasComplementaresApp.Controllers
{
    public abstract class HorasComplementaresAppControllerBase: AbpController
    {
        protected HorasComplementaresAppControllerBase()
        {
            LocalizationSourceName = HorasComplementaresAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
