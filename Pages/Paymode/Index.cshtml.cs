using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;


namespace SupermarketWEB.Pages.PayMode
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;
        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<Paymodes> Paymode { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Paymode != null)
            {
                Paymode = await _context.Paymode.ToListAsync();
            }
        }
    }
}
