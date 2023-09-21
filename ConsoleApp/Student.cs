using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;

        // auto-implemented property
        public string NickName { get; private set; }  // (private) set

        public Student(string name, string nickName, int age, double finalGrade)
        {
            this.name = name;
            this.NickName = nickName;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        public Student(string name, string nickName) :this(name, nickName, 23, 0)
        {
            // :this() -> set default value
        }

        public void SayHello()
        {
            Console.WriteLine("Hello from {0}!", this.name);
        }

        // get and set properties
        public string Name
        {
            get
            {
                if (age > 18)
                {
                    return name;
                }
                else
                {
                    return "This student is too young.";
                }
            }
            set
            {
                if (value != "")  // passed -> input parameter
                {
                    name = value;
                }
            }
        }
    }
}
