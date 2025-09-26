using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BiggusTickus.Models;

namespace BiggusTickus.Data
{
    public class BiggusTickusContext : DbContext
    {
        public BiggusTickusContext (DbContextOptions<BiggusTickusContext> options)
            : base(options)
        {
        }

        public DbSet<BiggusTickus.Models.Show> Show { get; set; } = default!;
        public DbSet<BiggusTickus.Models.Category> Category { get; set; } = default!;
    }
}
