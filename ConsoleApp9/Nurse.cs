using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Nurse : Person
    {
        protected string shift;

        public Nurse(string name, string role, int age, int salary, string shift) : base(name, role, age, salary)
        {
            this.shift = shift;
        }

        public void TakeBloodtest()
        {
            Console.WriteLine("Sköterskan tar ett blodprov på patienterna");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Roll:" + role);
            Console.WriteLine("Ålder: " + age);
            Console.WriteLine("Lön: " + salary);
            Console.WriteLine("Skift: " + shift);
        }
    }
}
