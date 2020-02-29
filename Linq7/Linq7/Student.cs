using System;
using System.Collections.Generic;
using System.Text;

namespace Linq7
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public List<int> Mark { get; set; }
        public Student()
        {
            Mark = new List<int>();
        }
    }
}