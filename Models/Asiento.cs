using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Asiento
    {
        public int Id { get; set; }
        public Sala Sala { get; set; }
        public byte SalaId { get; set; }
        public int nroAsiento { get; set; }
        public bool estaOcupado { get; set; }
    }
}