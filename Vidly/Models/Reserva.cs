using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Reserva
    {
        public byte Id { get; set; }
        public Pelicula Pelicula { get; set; }
        public Funcion Funcion { get; set; }
        public byte FuncionId { get; set; }
        public byte PeliculaId { get; set; }
        public int CantidadDeAsientosAReservar { get; set; }
    }
}