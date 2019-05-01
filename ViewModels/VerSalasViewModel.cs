using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class VerSalasViewModel
    {
        public IEnumerable<Asiento> Asientos { get; set; }
        public int AsientosAReservar { get; set; }

    }
}