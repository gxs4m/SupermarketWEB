using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Models;
using SupermarketWEB.Data;

namespace SupermarketWEB.Pages.Paymode
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
        public Paymodes Paymode { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Paymode == null || Paymode == null)
            {
                return Page();
            }
            _context.Paymode.Add(Paymode);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }

    }
}
