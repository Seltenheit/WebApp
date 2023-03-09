using Microsoft.AspNetCore.Mvc;
using TestWebApp.Domain;
using TestWebApp.DTO;
using TestWebApp.Services;

namespace TestWebApp.Controllers
{
    public class CatalogController : Controller
    {
        private readonly DisplayCatalogService _catalogService;

        public CatalogController(DisplayCatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet("[controller]")]
        public async Task<IActionResult> GetAsync(string path)
        {
            try
            {
                var result = await _catalogService.GetCatalogAsync(path);

                if (!result.Any())
                    return NotFound();

                var dto = result.Select(x => new CatalogDTO { Name = x.Name, Url = $"https://localhost:7238/Catalog?path={x.Path}" });
                return Ok(dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
