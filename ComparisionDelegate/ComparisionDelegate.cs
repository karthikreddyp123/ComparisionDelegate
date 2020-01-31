using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisionDelegate
{
    class ComparisionDelegate
    {
        static void Main(string[] args)
        {
            //Array of Objects
            Student[] arrStudent = new Student[] { new Student() { Name = "Karthik" },
            new Student() { Name = "Rahul" },
            new Student() { Name = "Vivek" },
            new Student() { Name = "Aditya" }};

            Console.WriteLine("Before Sorting:");
            foreach (Student i in arrStudent)
            {
                Console.WriteLine(i.Name);
            }
            //Sort using delagate
            Array.Sort(arrStudent, delegate (Student s1, Student s2) { return s1.Name.CompareTo(s2.Name); });
            Console.WriteLine("After Sorting:");
            foreach (Student i in arrStudent)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadLine();
        }
    }
    public class Student : IComparable
    {
        public string Name { get; set; }
        //Defining CompareTo method
        public int CompareTo(object obj)
        {
            Student stuObj = obj as Student;
            if (stuObj != null)
            {
                return this.Name.CompareTo(stuObj.Name);
            }
            return -1;
        }
    }
}
