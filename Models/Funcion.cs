using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Funcion
    {
        public byte Id { get; set; }
        public DateTime horario { get; set; }

        
        public Sala Sala { get; set; }
        public Pelicula Pelicula { get; set; }

        public byte PeliculaId { get; set; }
        public byte tipoDePeliculaId { get; set; }
        public byte SalaId { get; set; }

    }
}