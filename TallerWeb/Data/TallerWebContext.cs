#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerWeb.Models;

namespace TallerWeb.Data
{
    public class TallerWebContext : DbContext
    {
        public TallerWebContext (DbContextOptions<TallerWebContext> options)
            : base(options)
        {
        }

        public DbSet<TallerWeb.Models.Users> Users { get; set; }
    }
}
