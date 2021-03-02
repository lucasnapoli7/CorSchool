using System;
using System.Collections.Generic;

namespace CorSchool.Entities
{
    public class School
    {
        public string UniqueId {get; private set;} = Guid.NewGuid().ToString();
        string name;
        public string Name
        {
            get { return "Copia " + name; }
            set { name = value.ToUpper(); }
        }
        public int FoundationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public School(string name, int year) => (Name, FoundationYear) = (name, year);
        public List<Course> Courses { get; set; }
        public School(string name, int year, SchoolTypes types, string country = "", string city = "")
        {
            Name=name;
            FoundationYear=year;
            Country=country;
            City=city;
        }

        public override string ToString() => ($"Name: {Name}, Type: {SchoolType}\nCountry: {Country}, City: {City}");
    }
}