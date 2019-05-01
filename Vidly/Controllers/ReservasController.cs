using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class ReservasController : Controller
    {
        private ApplicationDbContext _context;


        public ReservasController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Reservas
        public ActionResult Index()
        {

            var misReservas = _context.ReservasConfirmadas.Include(c => c.Funcion.Pelicula).ToList().Where((r => r.usuarioMail == User.Identity.Name));

            if (User.IsInRole("PuedeInsertarPeliculas"))
            {
                misReservas = _context.ReservasConfirmadas.Include(c => c.Funcion.Pelicula).ToList();

            }



            return View(misReservas);
        }

        public ActionResult NuevaReserva(int idFuncion, int idPelicula, int idSala)
        {
            var funcion = _context.Funciones.ToList().SingleOrDefault(r => r.Id == idFuncion);
            var sala = _context.Salas.ToList().SingleOrDefault(r => r.Id == funcion.SalaId);
            var pelicula = _context.Peliculas.ToList().SingleOrDefault(r => r.Id == idPelicula);
            var asientos = _context.Asientos.ToList().FindAll(r => r.SalaId == idSala);
            var viewModel = new ReservaSalasViewModel

        {
            Funcion = funcion,
                Sala = sala,
            Pelicula = pelicula,
            Asientos = asientos

            };

            return View(viewModel);
        }

        public ActionResult VerFunciones(int idPelicula, int idtipo)
        {
            var funciones = _context.Funciones.ToList().Where(r => r.PeliculaId == idPelicula && r.tipoDePeliculaId == idtipo);
            var pelicula = _context.Peliculas.SingleOrDefault(p => p.Id == idPelicula);

            var viewModel = new verFuncionesViewModel
            {
                Pelicula = pelicula,
                Funcions = funciones,

            };

            return View(viewModel);
        }


        public ActionResult verSalas(Reserva reserva)
        {

            var funcion = _context.Funciones.ToList().SingleOrDefault(r => r.Id == reserva.FuncionId);
            var sala = _context.Salas.ToList().SingleOrDefault(r => r.Id == funcion.SalaId);
            var pelicula = _context.Peliculas.ToList().SingleOrDefault(r => r.Id == funcion.PeliculaId);
            var asientos = _context.Asientos.ToList().FindAll(r => r.SalaId == funcion.SalaId);
            var CantidadDeAsientosAReservar = reserva.CantidadDeAsientosAReservar;

            var viewModel = new ReservaSalasViewModel

            {
                Funcion = funcion,
                Sala = sala,
                Pelicula = pelicula,
                Asientos = asientos,
                CantidadDeAsientosAReservar = CantidadDeAsientosAReservar

            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult GuardarNuevaReserva(int[] tech)
        {
            int CantidadDeAsientosReservados = tech.Length;
            int asiento1 = 0;
            int asiento2 = 0;
            int asiento3 = 0;


            if (CantidadDeAsientosReservados == 1)
            {
                asiento1 = tech[0];
                var asientoTrue1 = _context.Asientos.ToList().SingleOrDefault(a => a.Id == asiento1);
                asientoTrue1.estaOcupado = true;


            }
            else if (CantidadDeAsientosReservados == 2)
            {
                asiento1 = tech[0];
                asiento2 = tech[1];
                var asientoTrue1 = _context.Asientos.ToList().SingleOrDefault(a => a.Id == asiento1);
                var asientoTrue2 = _context.Asientos.ToList().SingleOrDefault(a => a.Id == asiento2);

                asientoTrue1.estaOcupado = true;
                asientoTrue2.estaOcupado = true;

            }
            else if (CantidadDeAsientosReservados == 3)
            {
                asiento1 = tech[0];
                asiento2 = tech[1];
                asiento3 = tech[2];

                var asientoTrue1 = _context.Asientos.ToList().SingleOrDefault(a => a.Id == asiento1);
                var asientoTrue2 = _context.Asientos.ToList().SingleOrDefault(a => a.Id == asiento2);
                var asientoTrue3 = _context.Asientos.ToList().SingleOrDefault(a => a.Id == asiento3);

                asientoTrue1.estaOcupado = true;
                asientoTrue2.estaOcupado = true;
                asientoTrue3.estaOcupado = true;
            }


            var asiento = _context.Asientos.ToList().SingleOrDefault(a => a.Id == asiento1);
            var funcion = _context.Funciones.ToList().SingleOrDefault(f => f.Id == asiento.SalaId);
            var pelicula = _context.Peliculas.ToList().SingleOrDefault(p => p.Id == funcion.PeliculaId);
            var usuario = User.Identity.Name;

            
            var ReservasConfirmada = new ReservasConfirmadas()
            {
                Funcion = funcion,
                asiento1 = asiento1,
                asiento2 = asiento2,
                asiento3 = asiento3,
                usuarioMail = usuario


            };

            _context.ReservasConfirmadas.Add(ReservasConfirmada);
            _context.SaveChanges();

            var viewModel = new ReservaConfirmadaViewModel()
            {
                ReservasConfirmadas = ReservasConfirmada,
                Pelicula = pelicula

            };



            return View("ConfirmacionReserva", viewModel);
        }




    }
}