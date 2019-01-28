using System.Threading.Tasks;
using Abp.Application.Services;
using QxdCtidApiSer.Sessions.Dto;

namespace QxdCtidApiSer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
