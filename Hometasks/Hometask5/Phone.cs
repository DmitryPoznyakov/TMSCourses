using System;
namespace Hometasks.Hometask5
{
	public class Phone
	{

		//Constuctors

		double number;
		string model;
		int weight;

		public Phone(double number, string model, int weight)
		{
			this.number = number;
			this.model = model;
			this.weight = weight;
		}

		public Phone(double number, string model) : this (number, model, 0)
		{

		}

		public Phone()
		{

		}

        //GetInfo

        public void GetInfo()
		{
			Console.WriteLine($"Number: {number}, model: {model}, Weight: {weight}");
		}

        //receiveCall

        public void receiveCall(String Name)
		{
			Console.WriteLine($"Звонит: {Name}");
		}

        public void receiveCall(string Name, double number)
        {
            Console.WriteLine($"Звонит: {Name}, Номер: {number}");
        }

        //getNumber

        public void getNumber()

		{
			Console.WriteLine($"Номер: {number}");
		}

        //sendMessage

        public void sendMessage(params double[] Numbers)
        {
            Console.WriteLine("Сообщение отправлено:");
            foreach (double nubmer in Numbers)
            {
                Console.WriteLine(nubmer);
            }
        }
    }
}

