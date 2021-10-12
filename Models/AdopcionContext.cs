using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace S3_Repaso_Formulario.Models
{
    public class AdopcionContext : DbContext
    {
        public DbSet<SolicitudAdopcion> SolicitudesAdopcion { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }

        public AdopcionContext(DbContextOptions dco) : base(dco) {
            

        }

    }
}