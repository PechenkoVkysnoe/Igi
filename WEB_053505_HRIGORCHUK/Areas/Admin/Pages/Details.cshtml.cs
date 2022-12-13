using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_053505_HRIGORCHUK.Data;
using WEB_053505_HRIGORCHUK.Entities;

namespace WEB_053505_HRIGORCHUK.Areas.Admin.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly WEB_053505_HRIGORCHUK.Data.ApplicationDbContext _context;

        public DetailsModel(WEB_053505_HRIGORCHUK.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products
                .Include(p => p.ProductCategory).FirstOrDefaultAsync(m => m.ProductId == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
