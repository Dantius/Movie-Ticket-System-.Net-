using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class ReservasConfirmadas
    {
        public int Id { get; set; }
        public Funcion Funcion { get; set; }
        public int asiento1 { get; set; }
        public int asiento2 { get; set; }
        public int asiento3 { get; set; }
        public string usuarioMail { get; set; }
        public byte FuncionId { get; set; }


        public ReservasConfirmadas()
        {
            
        }
    }
}