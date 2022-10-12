using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Person
    {
        protected string name;
        protected string role;
        protected int age;
        protected int salary;

        public Person(string name, string role, int age, int salary)
        {
            this.name = name;
            this.role = role;
            this.age = age;
            this.salary = salary;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Roll:" + role);
            Console.WriteLine("Ålder: " + age);
            Console.WriteLine("Lön: " + salary);
        }
    }
}
