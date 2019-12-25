using SimpleApiKey_ForStartup.DAL;
using SimpleApiKey_ForStartup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleApiKey_ForStartup.Controllers
{
    public class AllpersonsController : ApiController
    {
        public StudentsDataBase _db;
        public AllpersonsController()
        {
            _db = new StudentsDataBase();
        }

        // GET api/values
        public IEnumerable<Person> Get()
        {
            IEnumerable<Person> persons = _db.AllPerson();
            return persons;
        }

        // GET api/values/5
        public Person Get(int id)
        {
            Person person = _db.ChosenPercon(id);
            return person;
        }

        //POST api/values
        public Person Post([FromBody] Person person)
        {
           return _db.AddPerson(person);
        }

        // PUT api/values/5
        public Person Put(int id, [FromBody] Person person)
        {
            Person person1 = _db.UpdatePerson(id, person);
            return person1;
        }

        // DELETE api/values/5
        public IEnumerable<Person> Delete(int id)
        {
           return  _db.DeletePerson(id);

        }
    }
}
