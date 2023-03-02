using System;
namespace Hometasks;

internal class HomeTask2
{
    public static void Task1()
    {
        Console.Write("input the 1st number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("input a sign of arithmetic operation: ");
        string sign = Console.ReadLine();
        Console.Write("input the 2nd number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        double result;
        switch (sign)
        {
            case "+":
                result = number1 + number2;
                Console.WriteLine($"the result is:{result}");
                break;
            case "-":
                result = number1 - number2;
                Console.WriteLine($"the result is:{result}");
                break;
            case "/":
                if (number2 == 0)
                {
                    Console.WriteLine($"You can't devide to 0");
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine($"the result is:{result}");
                }
                break;
            case "*":
                result = number1 * number2;
                Console.WriteLine($"the result is:{result}");
                break;
            default:
                Console.WriteLine("error: wrong symbol");
                break;

        }

    }
    /*
     Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток [0 - 14] [15 - 35] [36 - 49][50 - 100].
Если да, то укажите, в какой именно промежуток.
Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
     */
    public static void Task2()
    {
        Console.Write("Type the number in range between 0 and 100: ");
        double number3 = Convert.ToDouble(Console.ReadLine());
        if ((number3 >= 0) && (number3 <= 14))
        {
            Console.WriteLine($"number {number3} is in range from 0 to 14");
        }
        else if ((number3 >= 15) && (number3 <= 35))
        {
            Console.WriteLine($"number {number3} is in range from 15 to 35");
        }
        else if ((number3 >= 36) && (number3 <= 49))
        {
            Console.WriteLine($"number {number3} is in range from 36 to 49");
        }
        else if ((number3 >= 50) && (number3 <= 100))
        {
            Console.WriteLine($"number {number3} is in range from 50 to 100");
        }
        else
            Console.WriteLine("Error: inputed number is not in the range from 0 to 100");
    }
    /*
     Напишите программу русско-английский переводчик.
Программа знает 10 слов о погоде.
Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
     */
    public static void Task3()
    {
        Console.Write("Welcome to the RU/ENG translator. Type the weather condition, that you want to translate to ENG:");
        string text = Console.ReadLine();
        switch (text)
        {
            case "туман":
            case "туманно":
            case "туманная":
            case "туманный":
                Console.WriteLine("Foggy");
                break;
            case "солнце":
            case "солнечно":
            case "солнечная":
            case "солнечный":
                Console.WriteLine("Sunny");
                break;
            case "дождь":
            case "дождливо":
            case "дождливая":
            case "дождливый":
                Console.WriteLine("Rainy");
                break;
            case "облачно":
            case "облачная":
            case "облака":
            case "облачный":
                Console.WriteLine("Cloudy");
                break;
            case "ясно":
            case "ясная":
            case "чисто":
            case "чистая":
                Console.WriteLine("Clear");
                break;
            case "ветер":
            case "ветренно":
            case "ветренная":
            case "сильный ветер":
                Console.WriteLine("Windy");
                break;
            case "тепло":
            case "теплая":
            case "теплый":
                Console.WriteLine("Warm");
                break;
            case "холодно":
            case "холодная":
            case "холод":
                Console.WriteLine("Cold");
                break;
            case "буря":
            case "метель":
                Console.WriteLine("Blizzard");
                break;
            case "шторм":
            case "штормовой":
            case "штормит":
                Console.WriteLine("Storm");
                break;
            default:
                Console.WriteLine("error: Это слово не поддерживается");
                break;
        }
    }
    /*
     Напишите программу, которая будет выполнять проверку чисел на четность.
Предложите два варианта решения поставленной задачи. 
     */
    public static void Task4v1()
    {
        Console.WriteLine("Type the number:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = a % 2;
        if (b == 0)
            Console.WriteLine("The number is Even");
        else
            Console.WriteLine("The number is Odd");
    }
    public static void Task4v2()
    {
        Console.WriteLine("Type the number:");
        double c = Convert.ToDouble(Console.ReadLine());
        double d = c / 2;
        double e = Math.Round(c / 2);
        if (d == e)
            Console.WriteLine("The number is Even");
        else
            Console.WriteLine("The number is Odd");
    }
}

