using System;
using System.Collections.Generic;

namespace CorSchool.Entities
{
    public class Student
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; } 
        public List<Tests> Test { get; set;}
        public Student(){
            UniqueId = Guid.NewGuid().ToString();
            Test = new List<Tests>(){};
            }
    }
}