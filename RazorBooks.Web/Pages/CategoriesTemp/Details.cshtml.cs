﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly RazorBooks.Web.Data.ApplicationDbContext _context;

        public DetailsModel(RazorBooks.Web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Models.Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                Category = category;
            }
            return Page();
        }
    }
}
