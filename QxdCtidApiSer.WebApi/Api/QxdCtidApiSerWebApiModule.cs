using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using QxdCtidApiSer.Ctids;

namespace QxdCtidApiSer.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(QxdCtidApiSerApplicationModule))]
    public class QxdCtidApiSerWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(QxdCtidApiSerApplicationModule).Assembly, "app")
                .Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));


            //Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder.For<ICtidRecogAppService>("CtidRecog/GetAllList").Build();
        }
    }
}
