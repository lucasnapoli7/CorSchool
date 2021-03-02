using System;
using System.Collections.Generic;
using CorSchool.Util;

namespace CorSchool.Entities
{
    public class Course:SchoolBaseObject, IPlace
    {
        public JourneyTypes Journey { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students{ get; set; }
        public string Address { get; set; } 
        public void ClearPlace()
        {
            string str = "Clearing place...";
            Printer.PrintLine(str.Length);
            Console.WriteLine(str);
            Console.WriteLine($"Course {Name} clear");
        }
    }
}