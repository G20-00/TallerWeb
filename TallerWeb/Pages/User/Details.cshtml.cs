#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TallerWeb.Data;
using TallerWeb.Models;

namespace TallerWeb.Pages.User
{
    public class DetailsModel : PageModel
    {
        private readonly TallerWeb.Data.TallerWebContext _context;

        public DetailsModel(TallerWeb.Data.TallerWebContext context)
        {
            _context = context;
        }

        public Users Users { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Users = await _context.Users.FirstOrDefaultAsync(m => m.userName == id);

            if (Users == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
