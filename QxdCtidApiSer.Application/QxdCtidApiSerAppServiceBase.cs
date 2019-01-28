using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using QxdCtidApiSer.Authorization.Users;
using QxdCtidApiSer.MultiTenancy;
using QxdCtidApiSer.Users;
using Microsoft.AspNet.Identity;

namespace QxdCtidApiSer
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class QxdCtidApiSerAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected QxdCtidApiSerAppServiceBase()
        {
            LocalizationSourceName = QxdCtidApiSerConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}