using System;
namespace Hometasks.Hometask6clinic
{
	public class Dentist : Doctor
	{
        public Dentist(string DoctorName, string Specialization) : base(DoctorName, Specialization) { }

        public override void Treatment()
		{
			Console.WriteLine("Treatment method: dentistry");
		}
	}
}

