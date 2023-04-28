using System;
namespace Hometasks.Hometask6clinic
{
	public class Doctor
	{
        public string DoctorName;
		public string Specialization;

		public Doctor(string DoctorName, string Specialization)
		{
			this.DoctorName = DoctorName;
			this.Specialization = Specialization;
		}

        public virtual void Treatment()
		{
			Console.WriteLine("Treatment method: unknown, you may die.");
		}
    }
}

