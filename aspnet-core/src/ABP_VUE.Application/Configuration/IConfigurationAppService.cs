using System.Threading.Tasks;
using ABP_VUE.Configuration.Dto;

namespace ABP_VUE.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
