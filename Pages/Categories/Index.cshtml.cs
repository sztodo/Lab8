
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sztodolnik_Mihaela_Lab8.Data;
using Sztodolnik_Mihaela_Lab8.Modles;

namespace Sztodolnik_Mihaela_Lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Sztodolnik_Mihaela_Lab8.Data.Sztodolnik_Mihaela_Lab8Context _context;

        public IndexModel(Sztodolnik_Mihaela_Lab8.Data.Sztodolnik_Mihaela_Lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}