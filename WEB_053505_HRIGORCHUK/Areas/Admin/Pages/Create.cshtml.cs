using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB_053505_HRIGORCHUK.Data;
using WEB_053505_HRIGORCHUK.Entities;

namespace WEB_053505_HRIGORCHUK.Areas.Admin.Pages
{
    public class CreateModel : PageModel
    {
        private readonly WEB_053505_HRIGORCHUK.Data.ApplicationDbContext _context;

        private readonly IWebHostEnvironment _environment;
        public CreateModel(ApplicationDbContext context,
        IWebHostEnvironment env)
        {
            _context = context;
            _environment = env;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();
            if (Image != null)
            {
                var fileName = $"{Product.ProductId}" + Path.GetExtension(Image.FileName);
                Product.Image = fileName;
                var path = Path.Combine(_environment.WebRootPath, "Images", fileName);
                using (var fStream = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(fStream);
                }
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
