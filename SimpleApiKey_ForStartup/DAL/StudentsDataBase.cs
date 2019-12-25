using SimpleApiKey_ForStartup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleApiKey_ForStartup.DAL
{
    public class StudentsDataBase
    {
        private List<Person> personsList;
        private static int id=9;
        public StudentsDataBase()
        {
            personsList = new List<Person>();
            personsList.Add(new Person { Id = 1, Name = "Mixail", Surname = "Rusakov", Age = 10 });
            personsList.Add(new Person { Id = 2, Name = "Evqeniy", Surname = "Popov", Age = 11 });
            personsList.Add(new Person { Id = 3, Name = "Stiv", Surname = "Jobs", Age = 12 });
            personsList.Add(new Person { Id = 4, Name = "Timur", Surname = "Vahab", Age = 13 });
            personsList.Add(new Person { Id = 5, Name = "Nazim", Surname = "Aziz", Age = 14 });
            personsList.Add(new Person { Id = 6, Name = "Sabina", Surname = "Kruchkova", Age = 15 });
            personsList.Add(new Person { Id = 7, Name = "Larisa", Surname = "Deminovna", Age = 16 });
            personsList.Add(new Person { Id = 8, Name = "Nabi", Surname = "Alekberov", Age = 17 });
        }

        public List<Person> AllPerson() { return personsList; }
        public Person ChosenPercon(int id)
        {
            Person person = personsList.FirstOrDefault(i => i.Id == id);
            return person;
        }

        public Person UpdatePerson(int id, Person person)
        {
            Person _person = personsList.FirstOrDefault(i => i.Id == id);
            _person.Name = person.Name;
            _person.Surname = person.Surname;
            _person.Age = person.Age;

            return _person;
        }
        public List<Person> DeletePerson(int id)
        {
            Person person = personsList.FirstOrDefault(i => i.Id == id);
            personsList.Remove(person);
            return personsList;
          
        }
        public Person AddPerson(Person person) {
            id++;
           Person createdperson = new Person() {Id = id, Name = person.Name, Surname = person.Surname, Age = person.Age};
            return createdperson;
        }

    }
}