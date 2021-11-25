using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Petrut_Alexandru_Lab8.Models;

namespace Petrut_Alexandru_Lab8.Data
{
    public class Petrut_Alexandru_Lab8Context : DbContext
    {
        public Petrut_Alexandru_Lab8Context (DbContextOptions<Petrut_Alexandru_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Petrut_Alexandru_Lab8.Models.Book> Book { get; set; }

        public DbSet<Petrut_Alexandru_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Petrut_Alexandru_Lab8.Models.Category> Category { get; set; }
    }
}
