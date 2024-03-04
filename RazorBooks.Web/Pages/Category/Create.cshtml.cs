using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBooks.Web.Data;

namespace RazorBooks.Web.Pages.Category
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        
        //[BindProperty]
        public Models.Category Category { get; set; } = null!;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() 
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name", "El nombre de la categoría no puede ser el mismo al del orden!");
                return Page();
            }

            if (ModelState.IsValid)
            {
                await _context.Categories.AddAsync(Category);
                await _context.SaveChangesAsync();
                TempData["success"] = "Categoria creada satisfactoriamente";
            }
            else
            {
                return Page();
            }
            return RedirectToPage("Index");
        }
    }
}
