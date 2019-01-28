using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using QxdCtidApiSer.EntityFramework;

namespace QxdCtidApiSer.Migrator
{
    [DependsOn(typeof(QxdCtidApiSerDataModule))]
    public class QxdCtidApiSerMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<QxdCtidApiSerDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}