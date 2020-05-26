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
    public class DetailsModel : PageModel
    {
        private readonly App.Data.Context _context;

        public DetailsModel(App.Data.Context context)
        {
            _context = context;
        }

        public Medias Medias { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medias = await _context.Medias.FirstOrDefaultAsync(m => m.Id == id);

            if (Medias == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
