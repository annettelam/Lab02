using Lab02.Model.NW;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Lab02.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            NorthwindContext _context = new NorthwindContext();

            var categories = _context.Categories
                .Select(c => new Category
                {
                    CategoryName = c.CategoryName,
                })
                .ToList();

            // Store categories in ViewData
            ViewData["Categories"] = categories;
        }
    }
}
