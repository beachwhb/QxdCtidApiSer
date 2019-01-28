using System.Threading.Tasks;
using Abp.Application.Services;
using QxdCtidApiSer.Configuration.Dto;

namespace QxdCtidApiSer.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}