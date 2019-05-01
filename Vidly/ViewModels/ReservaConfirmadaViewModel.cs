using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class ReservaConfirmadaViewModel
    {
        public ReservasConfirmadas ReservasConfirmadas { get; set; }
        public Pelicula Pelicula { get; set; }
    }
}