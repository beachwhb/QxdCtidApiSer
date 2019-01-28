using Abp.AutoMapper;
using QxdCtidApiSer.Sessions.Dto;

namespace QxdCtidApiSer.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}