using QxdCtidApiSer.EntityFramework;
using EntityFramework.DynamicFilters;

namespace QxdCtidApiSer.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly QxdCtidApiSerDbContext _context;

        public InitialHostDbBuilder(QxdCtidApiSerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
