using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {FirstName="Sara",SecondName="Mills", Age=24,},
                new Student {FirstName="Andrew",SecondName="Gibson", Age=21,},
                new Student {FirstName="Craig",SecondName="Ellis", Age=19,},
                new Student {FirstName="Steven",SecondName="Cole", Age=35,},
                new Student {FirstName="Andrew",SecondName="Carter", Age=15,},
            };

            var selectedStudents = from s in students
            where s.Age >= 18 && s.Age <= 24
            select s;

            foreach (Student s in selectedStudents)
            Console.WriteLine($"{s.FirstName} {s.SecondName} {s.Age}");
        }
    }
}
