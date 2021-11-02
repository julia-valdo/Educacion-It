using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEscuela.Data;
using WebApiEscuela.Models;

namespace WebApiEscuela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AlumnoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return context.Alumnos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            return context.Alumnos.Find(id);
        }

        [HttpPost]
        public ActionResult<Alumno> Post(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Alumno alumno)
        {
            if (id != alumno.Id)
                return BadRequest();

            context.Entry(alumno).State = EntityState.Modified;
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Alumno> Delete(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);

            if (alumno == null)
                return NotFound();

            context.Alumnos.Remove(alumno);
            context.SaveChanges();

            return alumno;
        }

        [HttpGet("GetByMatricula/{matricula}")]
        public IEnumerable<Alumno> GetByMatricula(string matricula)
        {
            var alumnos = (from a in context.Alumnos
                              where a.Matricula == matricula
                              select a).ToList();

            return alumnos;
        }

        [HttpGet("GetByCiudad/{ciudad}")]
        public IEnumerable<Alumno> GetByCiudad(string ciudad)
        {
            var alumnos = (from a in context.Alumnos
                           where a.Ciudad == ciudad
                           select a).ToList();

            return alumnos;
        }
    }
}
