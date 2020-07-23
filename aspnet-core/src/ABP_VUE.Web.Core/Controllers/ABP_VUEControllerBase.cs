using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABP_VUE.Controllers
{
    public abstract class ABP_VUEControllerBase: AbpController
    {
        protected ABP_VUEControllerBase()
        {
            LocalizationSourceName = ABP_VUEConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
