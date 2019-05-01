using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class PeliculasController : Controller
    {

        private ApplicationDbContext _context;

        public PeliculasController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var peliculas = _context.Peliculas.ToList();


            return View(peliculas);
        }


        public ActionResult Detalles(int id)
        {
            var pelicula = _context.Peliculas.SingleOrDefault(p => p.Id == id);

            if (pelicula == null)
            {
                return HttpNotFound();
            }
            return View(pelicula);
        }

        [HttpPost]
        public ActionResult Create(Pelicula nuevaPelicula)
        {
            _context.Peliculas.Add(nuevaPelicula);
            _context.SaveChanges();


            return RedirectToAction("Index", "Peliculas");
        }


        public ActionResult NuevaPelicula()

        {
            return View("NuevaPelicula");
        }


    }
}