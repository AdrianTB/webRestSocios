using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webRestSocios.Model;

namespace webRestSocios.Context
{
    public class BDContext : DbContext
    {

        // Representa a la base de datos
        public BDContext(DbContextOptions<BDContext> options) : base(options)
        {
        }

        // Representa a la tabla
        public DbSet<tb_socios> tb_socios { get; set; }



    }
}
