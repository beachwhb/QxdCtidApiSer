using Abp.Application.Services;
using Abp.Application.Services.Dto;
using QxdCtidApiSer.MultiTenancy.Dto;

namespace QxdCtidApiSer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
