using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {FirstName="Sara",SecondName="Mills",Phone="02435521",},
                new Student {FirstName="Andrew",SecondName="Gibson",Phone="0895223344",},
                new Student {FirstName="Craig",SecondName="Ellis",Phone="+3592667710",},
                new Student {FirstName="Steven",SecondName="Cole",Phone="3242133312",},
                new Student {FirstName="Andrew",SecondName="Carter",Phone="+001234532",},
            };

            var selectedStudent = from s in students
            where s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592")
            select s;

            foreach(Student s in selectedStudent)
            Console.WriteLine($"{s.FirstName} {s.SecondName}");
        }
    }
}
