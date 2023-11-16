using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Truta_Diana_Lab2.Models;

namespace Truta_Diana_Lab2.Data
{
    public class Truta_Diana_Lab2Context : DbContext
    {
        public Truta_Diana_Lab2Context (DbContextOptions<Truta_Diana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Truta_Diana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Truta_Diana_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Truta_Diana_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Truta_Diana_Lab2.Models.Category>? Category { get; set; }
    }
}
