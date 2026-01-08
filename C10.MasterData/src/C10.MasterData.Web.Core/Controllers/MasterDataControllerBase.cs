using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace C10.MasterData.Controllers
{
    public abstract class MasterDataControllerBase : AbpController
    {
        protected MasterDataControllerBase()
        {
            LocalizationSourceName = MasterDataConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
