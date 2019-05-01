using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<Asiento> Asientos { get; set; }

    }
}