using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet2.Models;

namespace dotnet2.Data
{
    public class dotnet2Context : DbContext
    {
        public dotnet2Context (DbContextOptions<dotnet2Context> options)
            : base(options)
        {
        }
        public DbSet<dotnet2.Models.Book>? Book { get; set; }
        public DbSet<dotnet2.Models.Publisher>? Publisher { get; set; }
        public DbSet<dotnet2.Models.Author>? Author { get; set; }

    }
}
