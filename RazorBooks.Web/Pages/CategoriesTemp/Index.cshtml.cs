using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorBooks.Web.Data;
using RazorBooks.Web.Models;

namespace RazorBooks.Web.Pages.CategoriesTemp
{
    public class IndexModel : PageModel
    {
        private readonly RazorBooks.Web.Data.ApplicationDbContext _context;

        public IndexModel(RazorBooks.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Categories.ToListAsync();
        }
    }
}
