using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TMS.Data.Contracts.EntityModels;
using TMS.Data.EntityModels;

namespace TMS.Data
{
    public class TMSContext : DbContext
    {
        public TMSContext(DbContextOptions<TMSContext> options) : base(options) {
            Database.EnsureCreated();
        }

        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<Tax> Taxes { get; set; }
    }
}
