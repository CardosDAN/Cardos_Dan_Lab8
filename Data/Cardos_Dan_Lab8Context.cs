using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cardos_Dan_Lab8.Models;

namespace Cardos_Dan_Lab8.Data
{
    public class Cardos_Dan_Lab8Context : DbContext
    {
        public Cardos_Dan_Lab8Context (DbContextOptions<Cardos_Dan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cardos_Dan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cardos_Dan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cardos_Dan_Lab8.Models.Category> Category { get; set; }
    }
}
