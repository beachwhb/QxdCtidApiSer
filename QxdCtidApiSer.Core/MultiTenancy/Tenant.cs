using Abp.MultiTenancy;
using QxdCtidApiSer.Authorization.Users;

namespace QxdCtidApiSer.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}