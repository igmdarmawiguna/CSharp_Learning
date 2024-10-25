using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication38
{
    class Student<T>
    {
        string name;
        T grade;
        public Student(string name, T grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return string.Format("Name :{0} \n Grade : {1}", name, grade);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student<int> s = new Student<int>("Budi", 1);
            Student<string> r = new Student<string>("Andi", "A");
            Console.WriteLine(s);
            Console.WriteLine(r);
    }
}
