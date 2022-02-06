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
using Microsoft.AspNetCore.Mvc.Rendering;


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

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
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }
        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
        
        }
}
