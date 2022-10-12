using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Doctor : Person
    {
        protected int workTime;

        public Doctor(string name, string role, int age, int salary, int workTime) : base(name, role, age, salary)
        {
            this.workTime = workTime;
        }

        public void PrintReciept()
        {
            Console.WriteLine("Läkaren " + name + ", skriver ut ett recept till alla patienter");
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Roll:" + role);
            Console.WriteLine("Ålder: " + age);
            Console.WriteLine("Lön: " + salary);
            Console.WriteLine("Arbetstid(h/vecka): " + workTime);
        }
    }
}
