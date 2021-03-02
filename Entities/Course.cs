using System;
using System.Collections.Generic;

namespace CorSchool.Entities
{
    public class Course:SchoolBaseObject
    {
        public JourneyTypes Journey { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students{ get; set; }
    }
}