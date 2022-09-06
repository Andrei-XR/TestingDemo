using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoLibrary.Tests
{
    public class DataAccessExamples
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModel person = new PersonModel { FirstName = "Foo", LastName = "Bar" };
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people, person);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModel>(person, people);
        }

        [Theory]
        [InlineData("Carl", "", "LastName")]
        [InlineData("", "Neil", "FirstName")]
        public void AddPersonToPeopleList_ShouldInvalid(string firstName, string lastName, string param)
        {
            PersonModel person = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, person));
        }
    }
}
