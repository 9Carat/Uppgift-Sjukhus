namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Alex", "Doctor", 35, 60000, 40);
            Nurse nurse1 = new Nurse("Birgitta", "Nurse", 82, 35000, "Natt");
            Patient patient1 = new Patient("Felicia", "Patient", 28, 30000, "Benfraktur(Alla ben)", new DateTime(2022, 10, 12), new DateTime(2022, 12, 5), false);
            Patient patient2 = new Patient("Anton", "Patient", 30, 20000, "Hjärnskakning", new DateTime(2022, 10, 1), new DateTime(2022, 10, 25), false);

            doctor1.PrintInfo();
            Console.WriteLine(" ");
            nurse1.PrintInfo();
            Console.WriteLine(" ");
            doctor1.PrintReciept();
            nurse1.TakeBloodtest();
            patient1.HasReciept = true;
            patient2.HasReciept = true;
            Console.WriteLine(" ");
            patient1.PrintInfo();
            Console.WriteLine(" ");
            patient2.PrintInfo();
        }
    }
}