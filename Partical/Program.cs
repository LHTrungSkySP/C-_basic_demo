using System;

namespace Basic_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "trung";
            student.age = 12;
            Console.WriteLine(student.ToString()); 
        }
    }
}