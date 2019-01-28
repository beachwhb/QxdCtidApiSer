using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using QxdCtidApiSer.Authorization.Roles;
using QxdCtidApiSer.Authorization.Users;
using QxdCtidApiSer.Ctids;
using QxdCtidApiSer.MultiTenancy;

namespace QxdCtidApiSer.EntityFramework
{
    public class QxdCtidApiSerDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        public IDbSet<CtidRecog> CtidRecogs { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public QxdCtidApiSerDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in QxdCtidApiSerDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of QxdCtidApiSerDbContext since ABP automatically handles it.
         */
        public QxdCtidApiSerDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public QxdCtidApiSerDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public QxdCtidApiSerDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
