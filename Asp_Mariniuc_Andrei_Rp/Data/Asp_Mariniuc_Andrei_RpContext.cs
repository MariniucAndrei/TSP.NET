using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Mariniuc_Andrei_Rp.Models;

namespace Asp_Mariniuc_Andrei_Rp.Data
{
    public class Asp_Mariniuc_Andrei_RpContext : DbContext
    {
        public Asp_Mariniuc_Andrei_RpContext (DbContextOptions<Asp_Mariniuc_Andrei_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Mariniuc_Andrei_Rp.Models.Movie> Movie { get; set; }
    }
}
