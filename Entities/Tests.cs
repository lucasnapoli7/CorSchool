using System;
using CorSchool.Entities;

namespace CorSchool.Entities
{
    public class Tests
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Subjects Subjects { get; set; }
        public float Grade{ get; set; }
        public Tests() => UniqueId = Guid.NewGuid().ToString();
    }
}