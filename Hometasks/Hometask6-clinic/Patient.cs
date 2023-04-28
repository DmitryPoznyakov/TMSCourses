using System;
namespace Hometasks.Hometask6clinic
{
	public class Patient
	{
		public string PatientName;
		public int TreatmentCode;

		public Patient(string PatientName, int TreatmentCode)
		{
			this.PatientName = PatientName;
			this.TreatmentCode = TreatmentCode;
		}

		public void GetTreatmentPlan()
		{
			if (TreatmentCode == 1)
			Console.WriteLine($"ThreatmentCode for the patient {PatientName} is {TreatmentCode}");
			Console.WriteLine($"Assigned Doctor is ");
		}
	
	}
}

