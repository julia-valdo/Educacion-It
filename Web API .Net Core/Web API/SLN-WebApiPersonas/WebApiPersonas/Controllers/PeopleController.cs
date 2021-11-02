using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiPersonas.Data;
using WebApiPersonas.Models;

namespace WebApiPersonas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        #region Inyeccion de dependencia
        private readonly PeopleDbContext context;

        public PeopleController(PeopleDbContext context)
        {
            this.context = context;
        }
        #endregion

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return context.People.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return context.People.Find(id);
        }

        [HttpPost]
        public ActionResult<Person> Post(Person person)
        {
            context.People.Add(person);
            context.SaveChanges();

            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Person person)
        {
            if (id != person.Id)
                return BadRequest();

            context.Entry(person).State = EntityState.Modified;
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Person> Delete(int id)
        {
            Person person = context.People.Find(id);

            if (person == null)
                return NotFound();

            context.People.Remove(person);
            context.SaveChanges();

            return person;
        }

        // api/People/GetByName/Julia
        [HttpGet("GetByName/{name}")]
        public IEnumerable<Person> GetByName(string name)
        {
            var people = (from p in context.People
                          where p.Name == name
                          select p).ToList();

            return people;
        }
    }
}
