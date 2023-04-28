using System;
namespace Hometasks.Hometask6clinic
{
	public class Therapist : Doctor
	{
        public Therapist(string DoctorName, string Specialization) : base(DoctorName, Specialization) { }

        public override void Treatment()
        {
            Console.WriteLine("Treatment method: therapeutic");
        }
	}
}

