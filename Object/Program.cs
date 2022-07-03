using System;
using System.Collections.Generic;
using System.Linq;

namespace Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Name = "Trung", Birthplace ="Ha Noi", YearOfBirth=2001},
                new Student() { Name ="Anh",Birthplace ="Quang Binh",YearOfBirth=2005},
                new Student(){ Name ="Binh",Birthplace="Ha Noi",YearOfBirth=2003}
            };
            var ds = from sv in students
                          where sv.Birthplace == "Ha Noi"
                          select new /*kiểu vô danh chỉ đọc không ghi*/
                          {
                              Name = sv.Name,
                              Birthplace = sv.Birthplace,
                          };
            foreach (var student in ds)
            {
                Console.WriteLine(student);
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Birthplace { get; set; }
        public int YearOfBirth { get; set; }

    }
}
