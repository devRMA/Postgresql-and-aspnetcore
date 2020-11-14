using Microsoft.EntityFrameworkCore;
using Postgresql_and_aspnetcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postgresql_and_aspnetcore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
