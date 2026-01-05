using C10.Configuration.Dto;
using System.Threading.Tasks;

namespace C10.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
