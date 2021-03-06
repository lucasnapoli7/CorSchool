using System;
using System.Collections.Generic;
using System.Linq;
using CorSchool.Entities;

namespace CorSchool.App
{
    public sealed class SchoolEngine
    {
        public School school { get; set; }

        public SchoolEngine()
        {

        }

        public void Initialize()
        {
            school = new School("Platzi Academy", 2012, SchoolTypes.GradeSchool, city: "Bogotá");
            CoursesLoad();
            SubjectsLoad();
            TestsLoad();
        }

        private void TestsLoad()
        {
            foreach (var course in school.Courses)
            {
                //Console.WriteLine($"\n{course.Name}");
                foreach (var subject in course.Subjects)
                {
                    foreach (var student in course.Students)
                    {
                        var rnd = new Random();
                        for (int i = 1; i <= 5; i++)
                        {
                            var test = new Test{
                                Name = $"{subject.Name} Test#{i}",
                                Subjects = subject,
                                Note = (float)(10*rnd.NextDouble()),
                                Student = student
                            };
                            //Console.WriteLine($"{student.Name} - {test.Name}: {test.Note}");
                            student.Tests.Add(test);
                        }
                    }
                }   
            }
        }

        public List<SchoolBaseObject> GetSchoolObjects()
        {
            var objList = new List<SchoolBaseObject>();
            objList.Add(school);
            objList.AddRange(school.Courses);
            foreach (var course in school.Courses)
            {
                objList.AddRange(course.Subjects);   
                objList.AddRange(course.Students);

                foreach (var student in course.Students)
                {
                    objList.AddRange(student.Tests);
                }   
            }

            return objList;
        }

        private void SubjectsLoad()
        {
            foreach (var course in school.Courses)
            {
                List<Subject> subjectsList = new List<Subject>(){
                    new Subject{Name="Math"},
                    new Subject{Name="Physical education"},
                    new Subject{Name="Spanish"},
                    new Subject{Name="Natural Sciences"},
                };
                course.Subjects= subjectsList;
            }
        }

        private List<Student> StudentRandomGenerate(int quantity)
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            
            var studentList =   from n1 in name1
                                from n2 in name2
                                from l1 in lastname1
                                select new Student{Name=$"{n1} {n2} {l1}"};

            return studentList.OrderBy((stu)=> stu.UniqueId).Take(quantity).ToList();            
        }

        private void CoursesLoad()
        {
            school.Courses = new List<Course>(){
                new Course { Name = "101", Journey= JourneyTypes.Morning },
                new Course { Name = "201", Journey= JourneyTypes.Morning },
                new Course { Name = "301", Journey= JourneyTypes.Morning },
                new Course { Name = "401", Journey= JourneyTypes.Morning },
                new Course { Name = "501", Journey= JourneyTypes.Morning },
                new Course { Name = "501", Journey= JourneyTypes.Afternoon}
            };
            Random rnd = new Random();
            
            foreach (var c in school.Courses)
            {
                int randomQuan = rnd.Next(5, 20); //genera un entero, pero limitado entre 5 y 20
                c.Students = StudentRandomGenerate(randomQuan);
            }
        }
    }
}