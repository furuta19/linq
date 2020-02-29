using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                
                new Student {FacultyName="554214",Mark="6 6 6 5",},
                new Student {FacultyName="653215",Mark="3 4 5 6",},
                new Student {FacultyName="156212",Mark="4 2 3 4",},
                new Student {FacultyName="324413",Mark="5 6 5 5",},
                new Student {FacultyName="134014",Mark="5 3 4 2",},
            };
            var selectedStudent = from s in students
                                  where s.FacultyName.EndsWith("14") || s.FacultyName.EndsWith("15")
                                  select s;

            foreach (Student s in selectedStudent)
            Console.WriteLine($"{s.Mark}");

        }
    }
}
