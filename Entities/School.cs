using System;
using System.Collections.Generic;
using CorSchool.Util;

namespace CorSchool.Entities
{
    public class School:SchoolBaseObject, IPlace
    {
        public int FoundationYear { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public School(string name, int year) => (Name, FoundationYear) = (name, year);
        public List<Course> Courses { get; set; }
        public string Address { get; set; }

        public School(string name, int year, SchoolTypes types, string country = "", string city = "")
        {
            Name=name;
            FoundationYear=year;
            Country=country;
            City=city;
        }

        public override string ToString() => ($"Name: {Name}, Type: {SchoolType}\nCountry: {Country}, City: {City}");

        public void ClearPlace()
        {
            string str = "Clearing school...";
            Printer.PrintLine(str.Length);
            Console.WriteLine(str);
            foreach (var course in Courses)
            {
                course.ClearPlace();
            }
            Printer.PrintTitle($"School {Name} clear");;
        }
    }
}