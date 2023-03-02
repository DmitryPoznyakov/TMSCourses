using System;
namespace Hometasks;

internal class HomeTask3
{

    /*
        Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том,
        входит ли заданное число в массив или нет. Пусть число для поиска задается с консоли.
        */

    public static void Task1()
    {
        Random random = new Random();

        //задаем параметры массивов

        Console.Write("Укажите длину создаваемого массива: ");
        int MassiveLength = (int)Convert.ToInt32(Console.ReadLine());

        Console.Write("укажите искомое число в диапазоне от 0 до 10: ");
        int number1 = (int)Convert.ToInt32(Console.ReadLine());

        //заполняем массив

        int[] massive1 = new int[MassiveLength];

        for (int i = 0; i < MassiveLength; i++)
        {
            massive1[i] = (int)random.NextInt64(0, 10);
        }

        //выводим массив с искомым числом

        for (int i = 0; i < MassiveLength; i++)
        {
            if (massive1[i] == number1)
                Console.WriteLine(massive1[i] + " - искомое число");
            else
                Console.WriteLine(massive1[i] + " ");

        }
        Console.WriteLine();
    }

    /*
    Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
В результате должен быть новый массив без указанного числа.
    */

    public static void Task2()
    {
        Random random = new Random();

        //Задаем параметры массива и игнорируемое число

        Console.Write("Укажите длину создаваемого массива: ");
        int MassiveLength2 = (int)Convert.ToInt32(Console.ReadLine());

        Console.Write("Укажите игнорируемое число в диапазоне от 0 до 10: ");
        int ignorednumber = (int)Convert.ToInt32(Console.ReadLine());

        //заполняем массив рандомными числами

        int[] massive2 = new int[MassiveLength2];

        for (int i = 0; i < MassiveLength2; i++)
        {
            massive2[i] = (int)random.NextInt64(0, 10);
        }

        //выводим созданный массив

        int count1 = 0;
        for (int i = 0; i < MassiveLength2; i++)
        {
            count1++;
            if (massive2[i] == ignorednumber)
                Console.WriteLine(massive2[i] + " - игнорируемое число");
            else
                Console.WriteLine(massive2[i] + " ");
        }

        //выводим массив без игнорируемого числа

        Console.WriteLine();
        Console.WriteLine("Массив без игнорируемого числа: ");
        int count2 = 0;
        for (int i = 0; i < MassiveLength2; i++)
            if (massive2[i] != ignorednumber)
            {
                Console.WriteLine(massive2[i]);
                count2++;
            }
            else
                i = i++;
        if (count1 == count2)
        {
            Console.WriteLine("Массив не содержит исключаемого числа");
        }
        Console.WriteLine();
    }

    /*
    Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
Для генерации случайного числа используйте метод Random() .
    Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.
    */

    public static void Task3()
    {
        Random random = new Random();

        //Задаем параметры массива и игнорируемое число

        Console.Write("Укажите длину создаваемого массива: ");
        int MassiveLength3 = (int)Convert.ToInt32(Console.ReadLine());

        //заполняем массив рандомными числами

        int[] massive3 = new int[MassiveLength3];

        for (int i = 0; i < MassiveLength3; i++)
        {
            massive3[i] = (int)random.NextInt64(0, 10);
        }

        //выводим созданный массив
        Console.WriteLine("Созданный массив");
        for (int i = 0; i < MassiveLength3; i++)
        {
            Console.WriteLine(massive3[i] + " ");
        }
        int max = massive3[0];
        int min = massive3[0];
        double summ = 0;

        //максимальное значение

        for (int i = 0; i < MassiveLength3; i++)
        {
            if (max < massive3[i])
            {
                max = massive3[i];
            }
        }
        Console.Write("Maximu: " + max);

        //минимальное значение

        for (int i = 0; i < MassiveLength3; i++)
        {
            if (min > massive3[i])
            {
                min = massive3[i];
            }
        }
        Console.WriteLine();
        Console.Write("Minimum: " + min);

        //среднее значение

        for (int i = 0; i < MassiveLength3; i++)
        {
            summ = summ + massive3[i];
        }
        double average = summ / MassiveLength3;
        Console.WriteLine();
        Console.Write("Average: " + average);
        Console.WriteLine();
        Console.WriteLine();
    }

    /*
 Создайте 2 массива из 5 чисел.
Выведите массивы на консоль в двух отдельных строках.
Посчитайте среднее арифметическое элементов каждого массива и сообщите,
для какого из массивов это значение оказалось больше (либо сообщите,
что их средние арифметические равны).
 */
    public static void Task4()
    {
        Random random = new Random();
        //заполняем массивы рандомными числами

        int[] massive4 = new int[5];
        int[] massive5 = new int[5];

        for (int i = 0; i < massive4.Length; i++)
        {
            massive4[i] = (int)random.NextInt64(0, 100);
        }

        for (int j = 0; j < massive5.Length; j++)
        {
            massive5[j] = (int)random.NextInt64(0, 100);
        }

        //выводим созданные массивы
        Console.WriteLine("Созданный массив N1");
        for (int i = 0; i < massive4.Length; i++)
        {
            Console.WriteLine(massive4[i] + " ");
        }
        Console.WriteLine("Созданный массив N2");
        for (int j = 0; j < massive5.Length; j++)
        {
            Console.WriteLine(massive5[j] + " ");
        }

        //среднее значение

        double summ1 = 0;
        double summ2 = 0;

        for (int i = 0; i < massive4.Length; i++)
        {
            summ1 = summ1 + massive4[i];
        }
        double average1 = summ1 / massive4.Length;
        for (int j = 0; j < massive5.Length; j++)
        {
            summ2 = summ2 + massive5[j];
        }
        double average2 = summ2 / massive5.Length;
        Console.WriteLine();
        Console.WriteLine("Среднее значение 1-го массива: " + average1);
        Console.WriteLine("Среднее значение 2-го массива: " + average2);

        //Сравнение среднего значения 2-х массивов

        if (average1 == average2)
            Console.WriteLine("Средние значения массивов равно");
        else if (average1 > average2)
            Console.WriteLine("Среднее значение массива N1 > среднего значения массива N2");
        else
            Console.WriteLine("Среднее значение массива N1 > среднего значения массива N2");
        Console.WriteLine();
    }
    /*
     Создайте массив из n случайных целых чисел и выведите его на экран.
Размер массива пусть задается с консоли и размер массива может быть больше 5 и меньше или равно 10.
Если n не удовлетворяет условию - выведите сообщение об этом. Если пользователь ввёл не подходящее число,
    то программа должна просить пользователя повторить ввод.
Создайте второй массив только из чётных элементов первого массива, если они там есть, и вывести его на экран.
     */
    public static void Task5()
    {
        Random random = new Random();

        //задаем параметры массивов

        Console.Write("Укажите длину создаваемого массива: ");
        int MassiveLength = (int)Convert.ToInt64(Console.ReadLine());

        //заполняем массив

        int[] massive1 = new int[MassiveLength];

        for (int i = 0; i < MassiveLength; i++)
        {
            massive1[i] = (int)random.NextInt64(0, 100);
        }

        //выводим массив + массив из четных чисел
        if (MassiveLength <= 10 && MassiveLength > 5)
        {
            for (int i = 0; i < MassiveLength; i++)
                Console.WriteLine(massive1[i]);

            Console.WriteLine("массив из четных чисел: ");
            for (int i = 0; i < MassiveLength; i++)
            {
                if ((massive1[i] % 2) == 0)
                    Console.WriteLine(massive1[i]);
            }
        }
        else
            Console.WriteLine("error: Введите правильную длину массива");
        Console.WriteLine();
    }
    /*
     Создайте массив и заполните массив.
Выведите массив на экран в строку.
Замените каждый элемент с нечётным индексом на ноль.
Снова выведете массив на экран на отдельной строке.
     */
    public static void Task6()
    {
        Random random = new Random();

        //задаем параметры массивов

        Console.Write("Укажите длину создаваемого массива: ");
        int MassiveLength = (int)Convert.ToInt64(Console.ReadLine());

        //заполняем массив

        int[] massive1 = new int[MassiveLength];

        for (int i = 0; i < MassiveLength; i++)
        {
            massive1[i] = (int)random.NextInt64(1, 10);
        }

        //выводим массив + массив c 0 вместо нечетных индексов

        for (int i = 0; i < MassiveLength; i++)
            Console.Write(massive1[i] + " ");

        Console.WriteLine();

        Console.WriteLine("массив с 0 вместо нечетных индексов: ");
        for (int i = 0; i < MassiveLength; i++)
        {
            if ((i % 2) == 0)
                Console.Write(massive1[i] + " ");
            else
                Console.Write(0 + " ");
        }
        Console.WriteLine();
    }
}

