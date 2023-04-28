using System;
namespace Hometasks.Hometask6clinic
{
    public class Clinic
    {
        static void Main(string[] args)
        {
            Doctor Doctor1 = new Doctor("Vlad", "Surger");
            Doctor1.Treatment();

            Doctor Doctor2 = new Surgeon("Valera", "Surgeon");
            Doctor2.Treatment();

            Patient patient1 = new Patient("Petr",1);


        }

    }
}

