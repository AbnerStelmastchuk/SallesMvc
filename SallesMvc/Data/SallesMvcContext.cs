using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SallesMvc.Models
{
    public class SallesMvcContext : DbContext
    {
        public SallesMvcContext (DbContextOptions<SallesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SallesMvc.Models.Department> Department { get; set; }
    }
}
