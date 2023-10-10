using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Method;

namespace Class_Method
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight = aWeight; //the word this ia an explicit may of as
            this.name = aName;
            this.age = aAge;
        }

        //you ow have one stop to test obesity of your student and
        public bool IsObese()
        {
            if (weight > 60)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(70, "John", 15);
        Student student2 = new Student(40, "Tim", 10);


        Console.WriteLine(student1.IsObese());
        Console.WriteLine(student2.IsObese());

        Console.ReadLine();
    }
}
