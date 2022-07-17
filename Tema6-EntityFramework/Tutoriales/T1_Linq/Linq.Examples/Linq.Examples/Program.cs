using Linq.Examples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Examples
{
     class Program
    {
        static IList<Student> studentList = new List<Student>()
        {
            new Student() { StudentId = 1, StudentName = "Jhon", Age = 18, StandardID = 1 },
            new Student() { StudentId = 2, StudentName = "Steve", Age = 21, StandardID = 1 },
            new Student() { StudentId = 3, StudentName = "Bill", Age = 18, StandardID = 2 },
            new Student() { StudentId = 4, StudentName = "Ram", Age = 20, StandardID = 2 },
            new Student() { StudentId = 5, StudentName = "Rom", Age = 21}

        };

        static IList<Standard> standardList = new List<Standard>()
        {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}

        };


        static void Main(String[] args) 
        {
            var test = studentList.Where (x => (x.Age >= 18 && x.StandardID > 0)).Select(x => x.StudentName);

            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { Name2 = s.StudentName };

            var studentsGroupByStandard = from s in studentList
                                          where s.Age > 12 && s.Age < 20
                                          group s by s.StandardID into g
                                          orderby g.Key
                                          select new 
                                          { StandardID = g.Key,
                                            Items = g
                                          };

            var studentWithStandard = from s in studentList
                                      join st in standardList
                                      on s.StandardID equals st.StandardID
                                      select new
                                      {
                                          StudentName = s.StudentName,
                                          StandardID = st.StandardName,
                                      };

            foreach(var element in studentWithStandard)
            { 
               Console.WriteLine($"Student: {element.StudentName} is in {element.StandardID}");
            }


            Console.ReadKey();
        }
    }
}
