using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP_VUE.Configuration.Dto;

namespace ABP_VUE.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABP_VUEAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
