using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SupermarketWEB.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;
        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }
        public IList<Customer> Customers { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Customers != null)
            {
                Customers = await _context.Customers.ToListAsync();
            }
        }
    }
}
  