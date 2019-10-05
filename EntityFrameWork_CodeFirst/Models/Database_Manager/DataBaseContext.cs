using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWork_CodeFirst.Models.Database_Manager
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DataBaseContext()
        {
            Database.SetInitializer(new VeriTabani());
        }
    }
    public class VeriTabani:CreateDatabaseIfNotExists<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            //Persons insert
            for (int i = 0; i < 10; i++)
            {
                Person person = new Person();
                person.Name = FakeData.NameData.GetFirstName();
                person.SurName = FakeData.NameData.GetSurname();
                person.Age = FakeData.NumberData.GetNumber(17,54);
                context.Persons.Add(person);
            }
            context.SaveChanges();

            //Addreesses İnsert
            List<Person> allPersons = context.Persons.ToList();
            foreach (Person person in allPersons)
            {
                for (int i = 0; i < FakeData.NumberData.GetNumber(1,5); i++)
                {
                    Address address = new Address();
                    address.AddressDefinition = FakeData.PlaceData.GetAddress();
                    address.Persons = person;

                    context.Addresses.Add(address);
                }
            }
            context.SaveChanges();
        }
    }
}