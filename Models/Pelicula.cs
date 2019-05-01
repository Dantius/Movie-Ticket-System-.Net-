
using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Vidly.Models
{
    public class Pelicula
    {

        public int Id { get; set; }

        [StringLength(255)]
        [Display(Name = "Nombre de la Pelicula:")]
        public string Nombre { get; set; }

        [Required]
        public string Descripcion { get; set; }
        [Display(Name = "Fecha de Estreno:")]
        public string FechaDeEstreno { get; set; }

        [Display(Name = "Poster:")]

        public string imagen { get; set; }


    }
}