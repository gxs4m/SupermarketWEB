using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Models;
using SupermarketWEB.Data;
using Microsoft.EntityFrameworkCore;

namespace SupermarketWEB.Pages.Customers
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
        public Customer Customer { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || Customer == null)
            {
                return Page();
            }
            _context.Customers.Add(Customer);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
