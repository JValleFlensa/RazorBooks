using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorBooks.Web.Data;

namespace RazorBooks.Web.Pages.Category
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public Models.Category Category { get; set; } = null!;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Category = _context.Categories.FirstOrDefault(c => c.Id == id)!;
            if (Category == null)
            {
                NotFound();
            }
        }

        public IActionResult OnPost()
        {
            _context.Remove(Category);
            _context.SaveChanges();
            TempData["success"] = "Categoria eliminada satisfactoriamente";
            return RedirectToPage("Index");
        }
    }
}
