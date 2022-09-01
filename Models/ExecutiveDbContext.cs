using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMicroservice.Models
{
    public class ExecutiveDbContext : DbContext
    {
        public ExecutiveDbContext(DbContextOptions<ExecutiveDbContext> options) : base(options)
        {

        }

        public DbSet<Executive> Executives { get; set; }
    }
}
