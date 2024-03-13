using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePonto.Data
{
    internal class ControlePontoDbContext : DbContext
    {
        public ControlePontoDbContext(DbContextOptions<ControlePontoDbContext> opitions) : base (opitions)
        {

        }

        public 
    }

}
