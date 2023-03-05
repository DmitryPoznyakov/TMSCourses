using System;
namespace Hometasks;

internal class HomeTask4
{
	public static void Task1()
	{
		Console.Write("Write the sentence, that contain word 'test' and numbers: ");
		string textstart;
		textstart = Console.ReadLine();
		textstart = textstart.Replace("test", "testing");
        Console.Write("The result is: ");
        for (int i = 0; i < textstart.Length; i++)
			if (char.IsDigit(textstart[i]))

			{
				Console.Write("");
			}
		else
			Console.Write(textstart[i]);
	}
}
