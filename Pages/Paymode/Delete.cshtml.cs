using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Paymode
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _context;
        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Paymodes Paymode { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Paymode == null)
            {
                return NotFound();
            }
            var paymode = await _context.Paymode.FirstOrDefaultAsync(m => m.Id == id);
            if (paymode == null)
            {
                return NotFound();
            }
            else
            {
                Paymode = paymode;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Paymode == null)
            {
                return NotFound();
            }
            var paymode = await _context.Paymode.FindAsync(id);
            if (paymode != null)
            {
                Paymode = paymode;
                _context.Paymode.Remove(Paymode);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
