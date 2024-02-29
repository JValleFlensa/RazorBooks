using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBooks.Web.Data;

namespace RazorBooks.Web.Pages.Category
{
    [BindProperties]
    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        public Models.Category Category { get; set; } = null!;

        public EditModel(ApplicationDbContext context)
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
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name", "El nombre de la categoría no puede ser el mismo al del orden!");
                return Page();
            }

            if (ModelState.IsValid)
            {
                _context.Categories.Update(Category);
                _context.SaveChanges();
            }
            return RedirectToPage(nameof(Index));
        }
    }
}

