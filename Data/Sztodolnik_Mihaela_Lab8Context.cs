using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sztodolnik_Mihaela_Lab8.Modles;

namespace Sztodolnik_Mihaela_Lab8.Data
{
    public class Sztodolnik_Mihaela_Lab8Context : DbContext
    {
        public Sztodolnik_Mihaela_Lab8Context (DbContextOptions<Sztodolnik_Mihaela_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sztodolnik_Mihaela_Lab8.Modles.Book> Book { get; set; }

        public DbSet<Sztodolnik_Mihaela_Lab8.Modles.Publisher> Publisher { get; set; }

        public DbSet<Sztodolnik_Mihaela_Lab8.Modles.Category> Category { get; set; }
    }
}
