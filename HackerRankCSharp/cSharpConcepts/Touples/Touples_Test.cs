using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcepts.Touples
{
    public class Touples_Test
    {
        [Fact]
        public void Touples_1st_Test() 
        {
            var personTouple = ("John", "Doe", 30);
            Assert.Equal("John", personTouple.Item1);
            Assert.Equal("Doe", personTouple.Item2);
            Assert.Equal(30, personTouple.Item3);

            (string FirstName, string Lastname, int Age) namedTouple = ("John", "Doe", 30);
            Assert.Equal("John", namedTouple.FirstName);
            Assert.Equal("Doe", namedTouple.Lastname);
            Assert.Equal(30, namedTouple.Age);

            var toupleFromMethod = GiveMeATouple();
            Assert.Equal("John", toupleFromMethod.FirstName);
            Assert.Equal("Doe", toupleFromMethod.Lastname);
            Assert.Equal(30, toupleFromMethod.Age);

            //Touple Deconstruction
            var (firstName, lastName, age) = this.GiveMeATouple();
            Assert.Equal("John", firstName);
            Assert.Equal("Doe", lastName);
            Assert.Equal(30, age);
        }

        private (string FirstName, string Lastname, int Age) GiveMeATouple()
        {
            return ("John", "Doe", 30);
        }

        [Fact]
        public void PatterMatchingTouples_Test() 
        {
            (string FirstName, string LastName) person = ("John", "Doe");

            string switchResponse = "";
            switch (person)
            {
                case ("John", "Doe"):
                    switchResponse = "Found John Doe.";
                    break;
                case var (firstName, lastName) when firstName == "Jane":
                    switchResponse = $"Found Jane {lastName}.";
                    break;
                case var (firstName, lastName):
                    switchResponse = $"Found {firstName} {lastName}.";
                    break;
            }
            Assert.Equal("Found John Doe.", switchResponse);

            var ifResponse = "";
            if (person is ("John", "Doe"))
                ifResponse = "Found John Doe.";
            else if (person is var (firstName, lastName) && firstName == "Jane")
                ifResponse = $"Found Jane {lastName}.";
            else if (person is var (firstName2, lastName2))
                ifResponse = $"Found {firstName2} {lastName2}.";
            else
                ifResponse = "Person not found.";

            Assert.Equal("Found John Doe.", ifResponse);
        }
    }
}
