using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {

                new Person {FirstName="Ivaylo",SecondName="Petrov",GroupName=10,},
                new Person {FirstName="Stanimir",SecondName="Svilianov",GroupName=3,},
                new Person {FirstName="Indje",SecondName="Kromidov",GroupName=3,},
                new Person {FirstName="Irina",SecondName="Balabanova",GroupName=4,},

            };
            var sortedGroup = persons.OrderBy(s => s.GroupName);

            var personsGroup = from p in sortedGroup
                               group p by p.GroupName;

            foreach (IGrouping<int, Person> p in personsGroup)
            {
                Console.Write($"{p.Key} - ");
                foreach (var g in p)
                { Console.Write($"{g.FirstName} {g.SecondName}, "); }
                Console.WriteLine();
            }
        }
    }
}
