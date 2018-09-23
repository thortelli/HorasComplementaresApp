using System.Threading.Tasks;
using HorasComplementaresApp.Configuration.Dto;

namespace HorasComplementaresApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
