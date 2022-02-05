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
    public class IndexModel : PageModel
    {
        private readonly TallerWeb.Data.TallerWebContext _context;

        public IndexModel(TallerWeb.Data.TallerWebContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
