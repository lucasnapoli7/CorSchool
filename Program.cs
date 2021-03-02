using System;
using System.Collections.Generic;
using CorSchool.App;
using CorSchool.Entities;
using CorSchool.Util;
using static System.Console;

namespace CorSchool
{
    class Program
    {
        static void Main(string[] args)
        {
           var engine = new SchoolEngine();
           engine.Initialize();

           //PrintCourses(engine.school);
        }

        private static void PrintCourses(School school)
        {
            Printer.PrintTitle("School Courses");
            foreach (var Course in school.Courses)
            {
                WriteLine($"Name {Course.Name}, UniqueID {Course.UniqueId}");
            }
        }
    }
}
