using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {FirstName="Sara",SecondName="Gibson",},
                new Student {FirstName="Andrew",SecondName="Gibson",},
                new Student {FirstName="Craig",SecondName="Ellis",},
                new Student {FirstName="Steven",SecondName="Cole",},
                new Student {FirstName="Andrew",SecondName="Ellis",},
            };

            var selectedStudents = students.OrderBy(s => s.SecondName).ThenByDescending(s => s.FirstName);

            foreach (Student s in selectedStudents)
            Console.WriteLine($"{s.FirstName} {s.SecondName}");
        }
    }
}
