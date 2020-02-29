using System;
using System.Linq;
using System.Collections.Generic;
namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {FirstName="Sara",SecondName="Mills", GroupName=1,},
                new Student {FirstName="Andrew",SecondName="Gibson", GroupName=2,},
                new Student {FirstName="Craig",SecondName="Ellis", GroupName=1,},
                new Student {FirstName="Steven",SecondName="Cole", GroupName=2,},
                new Student {FirstName="Andrew",SecondName="Carter", GroupName=2,},
            };

            var selectedStudents = from s in students
            where s.FirstName.First() < s.SecondName.First()
            select s;

            foreach (Student s in selectedStudents)
            Console.WriteLine($"{s.FirstName} {s.SecondName}");
        }
    }
}