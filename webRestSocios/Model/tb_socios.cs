using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webRestSocios.Model
{

    public class tb_socios
    {
        [Key]
        public String id_socio { get; set;}
        public String nombre { get; set; }
        public String edad { get; set; }
        public String estado_civil { get; set; }
        public String profesion { get; set; }
        public String domicilio { get; set; }

    }
}
