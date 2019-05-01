using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class ReservaSalasViewModel
    {
        public Funcion Funcion { get; set; }
        public Sala Sala { get; set; }
        public Pelicula Pelicula { get; set; }
        public IEnumerable<Asiento> Asientos { get; set; }
        public int CantidadDeAsientosAReservar { get; set; }
    }
}