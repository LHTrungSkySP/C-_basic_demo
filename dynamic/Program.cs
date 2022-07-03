using System;

namespace dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Name="Trung",Birthplace="Ha Noi",YearOfBirth=18};
            Xuat(student);
        }
        static void Xuat(dynamic dvar)
        {
            Console.WriteLine(dvar.Name); // ở thời điểm biên dịch - không biết dvar có thuộc tính age hay không, nhưng nó vẫn biên dịch
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Birthplace { get; set; }
        public int YearOfBirth { get; set; }

    }
}
