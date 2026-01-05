using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace C10.Controllers
{
    public abstract class C10ControllerBase : AbpController
    {
        protected C10ControllerBase()
        {
            LocalizationSourceName = C10Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
