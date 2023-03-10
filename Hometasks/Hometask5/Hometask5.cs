using System;
namespace Hometasks.Hometask5
{
	//Task1

	internal class Hometask5
	{
		static void Main(string[] args)
		{
			Phone iPhone = new Phone(2020327, "iPhone 14", 172);
			Phone Galaxy = new Phone(7788, "Galaxy S23", 168);
			Phone Pixiel = new Phone(911, "Google Piexel 7", 197);

			Console.WriteLine("Presented SmartPhones: ");
			Galaxy.GetInfo();
			Pixiel.GetInfo();
			iPhone.GetInfo();

			iPhone.receiveCall("Carl");
			iPhone.getNumber();
			Console.WriteLine();

			Galaxy.receiveCall("Valera");
			Galaxy.getNumber();
            Console.WriteLine();

            Pixiel.receiveCall("Vasiliy");
			Pixiel.getNumber();
            Console.WriteLine();

            Pixiel.receiveCall("Boris",666);

			Pixiel.sendMessage(1212121212,2323232,343434,4222323232323232);
		}
	}

	//Task2
}

