using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasMvc.Models
{
    public class VendasMvcContext : DbContext
    {
        public VendasMvcContext (DbContextOptions<VendasMvcContext> options)
            : base(options)
        {
        }

        public DbSet<VendasMvc.Models.Department> Department { get; set; }
    }
}
