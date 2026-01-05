using Abp.Authorization;
using Abp.Runtime.Session;
using C10.Configuration.Dto;
using System.Threading.Tasks;

namespace C10.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : C10AppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
