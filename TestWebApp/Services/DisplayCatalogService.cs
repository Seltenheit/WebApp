using Microsoft.EntityFrameworkCore;
using TestWebApp.Domain;
using TestWebApp.Domain.Models;

namespace TestWebApp.Services
{
    public class DisplayCatalogService
    {
        private readonly CatalogContext _context;

        public DisplayCatalogService(CatalogContext context)
        {
            _context = context;
        }

        public async Task <IList<Catalog>> GetCatalogAsync(string path)
        {
            return await _context.Catalogs.Where(x => x.Parent != null && x.Parent.Path == path).ToListAsync();


        }
    }
}
