using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Stopawoodwork.Models
{
    public class StopaContext : DbContext
    {
        public StopaContext(DbContextOptions<StopaContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
