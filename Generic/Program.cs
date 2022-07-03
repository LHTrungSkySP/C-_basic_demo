using System;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "A";
            student1.age = 10;


            Student student2 = new Student();
            student2.name = "B";
            student2.age = 20;
            Console.WriteLine("Hoc sinh 1: " + student1.ToString());
            Console.WriteLine("Hoc sinh 2: " + student2.ToString());

            DoiCho(ref student1 ,ref  student2);
            Console.WriteLine("Doi cho student1 vaf student2: ");
            Console.WriteLine("Hoc sinh 1: " + student1.ToString());
            Console.WriteLine("Hoc sinh 2: " + student2.ToString());

            int a = 1, b = 2;
            Console.WriteLine($"a={a}; b={b}");
            DoiCho(ref a,ref b);
            Console.WriteLine("Doi cho a,b:");
            Console.WriteLine($"a={a}; b={b}");

            Console.WriteLine();

            Class<string> c = new Class<string>("abc");
            Console.WriteLine("Genetic: "+c.ToString());
        }
        static void DoiCho<T>(ref T a,ref T b)
        {
            T tam = a;
            a = b;
            b = tam;
        }

    }
    class Student
    {
        public int age { get; set; }
        public string name { get; set; }

        public string ToString() => "Name: " + name + " Age: "+age;
    }
    class Teacher
    {
        public string name{ get; set; }
        public int age { get; set; }
    }
    class Class<T>
    {
        public T bien;
        public Class(T value)
        {
            bien = value;
        }
        public string ToString() => "Name: " + bien;

    }


}
