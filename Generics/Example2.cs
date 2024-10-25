using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication38
{
    class Student<P, Q>
    {
        string name;
        P regno;
        Q grade;
        public Student(P regno, string name, Q grade)
        {
            this.regno = regno;
            this.name = name;
            this.grade = grade;
        }

        public override string ToString()
        {
            return string.Format("Regno : {2} \n Name :{0} \n Grade : {1}", name, grade, regno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student<int, string> s1 = new Student<int, string>(1, "Tony", "A");
            Student<string, int> s2 = new Student<string, int>("UNI-MYS04-0003", "Anton", 2);
            Student<string, string> s3 = new Student<string, string>("4NI03CS003", "Susi", "Second");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}