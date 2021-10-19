using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace S3_Repaso_Formulario.Models
{
    public class SolicitudAdopcion
    {
        public int Id { get; set; }

        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string DescripcionEspacio { get; set; }

        [Required]
        public string Celular { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }

    }
}