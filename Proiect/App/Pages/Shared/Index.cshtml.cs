using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using App.Data;
using App.Models;

namespace App
{
    public class IndexModel : PageModel
    {
        private readonly App.Data.Context _context;

        public IndexModel(App.Data.Context context)
        {
            _context = context;
        }

        public IList<Medias> Medias { get;set; }

        public async Task OnGetAsync()
        {
            Medias = await _context.Medias.ToListAsync();
        }
    }
}
