using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HorasComplementaresApp.Configuration.Dto;

namespace HorasComplementaresApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HorasComplementaresAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
