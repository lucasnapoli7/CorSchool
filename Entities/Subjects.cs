using System;

namespace CorSchool.Entities
{
    public class Subjects
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; } 
        public Subjects() => UniqueId = Guid.NewGuid().ToString();
    }
}