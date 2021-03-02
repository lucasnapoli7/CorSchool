using System;
using System.Collections.Generic;

namespace CorSchool.Entities
{
    public class Student: SchoolBaseObject
    {
        public List<Test> Tests { get; set;} = new List<Test>();
    }
}