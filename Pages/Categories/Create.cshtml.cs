using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;  
using SupermarketWEB.Models;
using System.Diagnostics;

namespace SupermarketWEB.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly SupermarketContext _context;
        public CreateModel(SupermarketContext context)
        {
            _context = context;
        }   
        
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine("Entrando a OnPostAsync");
            if (!ModelState.IsValid || _context.Categories == null || Category == null)
            {
                Console.WriteLine("ModelState no es válido o Categories es nulo o Category es nulo");
                return Page();
            }

            _context.Categories.Add(Category);
            await _context.SaveChangesAsync();
            Console.WriteLine("Guardando cambios en la base de datos");

            return RedirectToPage("./Index");
        }
    }
}
