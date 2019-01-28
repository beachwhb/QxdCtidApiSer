using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using QxdCtidApiSer.EntityFramework;

namespace QxdCtidApiSer
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(QxdCtidApiSerCoreModule))]
    public class QxdCtidApiSerDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<QxdCtidApiSerDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
