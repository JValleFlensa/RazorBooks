using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBooks.Web.Data;
using RazorBooks.Web;

namespace RazorBooks.Web.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IEnumerable<Models.Category> categories { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            categories = _context.Categories.ToList();
        }
    }
}
