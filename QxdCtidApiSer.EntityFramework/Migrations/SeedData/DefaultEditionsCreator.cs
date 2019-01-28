using System.Linq;
using Abp.Application.Editions;
using QxdCtidApiSer.Editions;
using QxdCtidApiSer.EntityFramework;

namespace QxdCtidApiSer.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly QxdCtidApiSerDbContext _context;

        public DefaultEditionsCreator(QxdCtidApiSerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}