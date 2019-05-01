using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class PeliculaDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }
        public string FechaDeEstreno { get; set; }


        public string imagen { get; set; }
    }
}