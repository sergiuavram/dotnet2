using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet2.Data;
using dotnet2.Models;

namespace dotnet2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly dotnet2.Data.dotnet2Context _context;

        public IndexModel(dotnet2.Data.dotnet2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
