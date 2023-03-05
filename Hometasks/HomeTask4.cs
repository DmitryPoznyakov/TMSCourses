using System;
namespace Hometasks;

internal class HomeTask4
{
    /*
Заменить в строке все вхождения 'test' на 'testing'. Удалить из текста все символы, являющиеся цифрами.
	 */

    public static void Task1()
    {
        Console.Write("Write the sentence, that contain word \"test\" and numbers: ");
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

    /*
Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
Welcome to the TMS lesons.
Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". Не забывайте о пробелах после каждого слова
    */

    public static void Task2()
    {
        string welcome = "\"Welcome\"";
        string to = "\"to\"";
        string the = "\"the\"";
        string tms = "\"TMS\"";
        string lessons = "\"lesons.\"";

        string[] array = new string[] { welcome, to, the, tms, lessons };
        string sentense = string.Join(" ", array);
        sentense = sentense.Replace("\"", "");

        Console.WriteLine(sentense);
    }

    /*
Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную, а также всё, что после них во вторую.
Результат вывести в консоль.
     */

    public static void Task3()
    {
        string sentence = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
        Console.WriteLine(sentence);

        string abc = "abc";
        int index = sentence.IndexOf(abc);

        string firstpart = sentence.Remove(index,(sentence.Length-index));
        string secondpart = sentence.Remove(0,index+abc.Length);

        Console.WriteLine("First part: " + firstpart);
        Console.WriteLine("Second part: " + secondpart);

    }

    /*
Дана строка: Плохой день.
Необходимо с помощью метода substring удалить слово "плохой". После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
Заменить последний "!" на "?"
     */

    public static void Task4()
    {
        string sentence = "Плохой день.";
        Console.WriteLine(sentence);

        string bad = "плохой";
        sentence = sentence.Substring(bad.Length);
        Console.WriteLine(sentence);

        sentence = sentence.Insert(0,"Хороший");
        sentence = sentence.Insert(sentence.Length-1, "!!!!!!!!!");
        Console.WriteLine(sentence);

        int index = sentence.LastIndexOf("!");
        sentence = sentence.Remove(index,1);
        sentence = sentence.Insert(index, "?");
        Console.WriteLine(sentence);
        
    }
}