using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lim_Matthew
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=csb-entpro.wongph.com;Database=ENTPRG_12101094_LIM;User Id=12106751; Password=oW0vO5yO; TrustServerCertificate =true");
        }
    }

}
