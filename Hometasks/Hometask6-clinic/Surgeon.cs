using System;
namespace Hometasks.Hometask6clinic
{
	public class Surgeon : Doctor
	{
        public Surgeon(string DoctorName, string Specialization) : base(DoctorName, Specialization) { }

        public override void Treatment()
        {
            Console.WriteLine("Treatment method: surgery");
        }
    }
}

