using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class PeliculasController : ApiController
    {
        private ApplicationDbContext _context;

        public PeliculasController()
        {
            _context = new ApplicationDbContext();
        }
        public IEnumerable<PeliculaDto> GetPeliculas()
        {
            return _context.Peliculas.ToList().Select(Mapper.Map<Pelicula,PeliculaDto>);
        }


        //GET /Api/peliculas/1
        public IHttpActionResult GetPelicula(int id)
        {
            var pelicula = _context.Peliculas.SingleOrDefault(c => c.Id == id);
            if (pelicula == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Pelicula, PeliculaDto>(pelicula));
        }


        //POst/APi/Peliculas
        [HttpPost]
        public IHttpActionResult CrearPelicula(PeliculaDto peliculaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var pelicula = Mapper.Map<PeliculaDto, Pelicula>(peliculaDto);

            _context.Peliculas.Add(pelicula);

            _context.SaveChanges();

            peliculaDto.Id = pelicula.Id;

            return Created(new Uri(Request.RequestUri + "/" + pelicula.Id), peliculaDto );
        }


        //PUT/api/peliculas/1
        [HttpPut]
        public void UpdatePelicula(int id, PeliculaDto peliculaDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var peliculaEnDb = _context.Peliculas.SingleOrDefault(c => c.Id == id);

            if (peliculaEnDb ==null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(peliculaDto, peliculaEnDb);
 
            _context.SaveChanges();

        }


        //DELETE / api/peliculas/1
        [HttpDelete]
        public void DeletePelicula(int id)
        {
            var peliculaEnDb = _context.Peliculas.SingleOrDefault(c => c.Id == id);

            if (peliculaEnDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Peliculas.Remove(peliculaEnDb);
            _context.SaveChanges();
        }
    }
}
