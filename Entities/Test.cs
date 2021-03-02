using System;
using CorSchool.Entities;

namespace CorSchool.Entities
{
    public class Test:SchoolBaseObject
    {
        public Student Student { get; set; }
        public Subject Subjects { get; set; }
        public float Note{ get; set; }
        public override string ToString()
        {
            return $"{Note}, {Student.Name}, {Subjects.Name}";
        }
    }
}