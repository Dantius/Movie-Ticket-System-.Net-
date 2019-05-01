using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
namespace Vidly.ViewModels
{
    public class verFuncionesViewModel
    {
        public Pelicula Pelicula { get; set; }
        public IEnumerable<Funcion> Funcions { get; set; }
        public Reserva Reserva { get; set; }


    }
}