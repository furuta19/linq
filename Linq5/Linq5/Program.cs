using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {FirstName="Sara",SecondName="Mills",Mail="smills@gmail.com",},
                new Student {FirstName="Andrew",SecondName="Gibson",Mail=" agibson@abv.bg",},
                new Student {FirstName="Craig",SecondName="Ellis",Mail="cellis@cs.edu.gov",},
                new Student {FirstName="Steven",SecondName="Cole",Mail="themachine@abv.bg",},
                new Student {FirstName="Andrew",SecondName="Carter",Mail="ac147@gmail.com",},
            };

            var selectedStudent = from s in students
            where s.Mail.Contains("@gmail.com")
            select s;

            foreach(Student s in selectedStudent)
            Console.WriteLine($"{s.FirstName} {s.SecondName}");
        }
    }
}
