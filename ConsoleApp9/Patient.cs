using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Patient : Person
    {
        protected string diagnosis;
        protected DateTime timeOfReg;
        protected DateTime timeOfDis;
        protected bool hasReciept;

        public bool HasReciept 
        {
            get
            {
                return hasReciept;
            }
            set
            {
                if(value == true)
                {
                    hasReciept = value;
                }
                else if(value == false)
                {
                    hasReciept = value;
                }
                else
                {
                    hasReciept = false;
                }
            }
        }

        public Patient(string name, string role, int age, int salary, string diagnosis, DateTime timeOfReg, DateTime timeOfDis, bool hasReciept) : base(name, role, age, salary)
        {
            this.diagnosis = diagnosis;
            this.timeOfReg = timeOfReg;
            this.timeOfDis = timeOfDis;
            this.hasReciept = hasReciept;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Ålder: " + age);
            Console.WriteLine("Diagnos: " + diagnosis);

            if (hasReciept == false)
            {
                Console.WriteLine("Patienten har ej något recept.");
            }
            else
            {
                Console.WriteLine("Patienten har recept.");
            }
            Console.WriteLine("RegIn: " + timeOfReg.ToShortDateString());
            Console.WriteLine("RegUt: " + timeOfDis.ToShortDateString());
        }
    }
}
