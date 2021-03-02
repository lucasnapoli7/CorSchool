using System;
using System.Collections.Generic;

namespace CorSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public JourneyTypes Journey { get; set; }
        public List<Subjects> Subjects { get; set; }
        public List<Student> Students{ get; set; }
        public Course() => UniqueId = Guid.NewGuid().ToString();
    }
}