using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student {FirstName="Sara",SecondName="Mills",Mark={6,6,6,5 },},
                new Student {FirstName="Andrew",SecondName="Gibson",Mark=new List<int> {3,4,5,6},},
                new Student {FirstName="Craig",SecondName="Ellis",Mark=new List<int> {4,2,3,4},},
                new Student {FirstName="Steven",SecondName="Cole",Mark=new List<int> {5,6,5,5},},
                new Student {FirstName="Andrew",SecondName="Carter",Mark=new List<int> {5,3,4,2},},
            };

            var selectedStudent = from s in students                        
                                  where s.Mark.Any(m => m == 6)
                                  select s;

            foreach (Student s in selectedStudent)
            Console.WriteLine($"{s.FirstName} {s.SecondName}"); 
        }
    }
}
