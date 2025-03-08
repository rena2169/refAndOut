using System;
using System.Collections.Generic;

namespace refAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Изменение значения через ref

            //Console.Write("Введите число: ");
            //int inputNumber;
            //if (int.TryParse(Console.ReadLine(), out inputNumber) && inputNumber != 0)
            //{
            //    Console.WriteLine($"число до метода: {inputNumber}");
            //    // Вызов метода для увелечения числа в двое
            //    DoubleValue(ref inputNumber);
            //    Console.WriteLine($"число после метода: {inputNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Пожалуйста, введите число или не 0!");
            //}

            // Метод с out для вычисления максимального значения из списка

            //List<int> numbers = new List<int>(); // создание списка
            //bool isOpen = true; // условие для добавления чисел в список
            //int maxNumber; // переменная для хранения максимального числа из списка

            //// добавление чисел в список
            //Console.WriteLine("добавление чисел в список");
            //while (isOpen)
            //{
            //    Console.WriteLine("варианты действий: добавить число - 1, выйти - 2");
            //    int actionNumber;
            //    // проверка введенного числа
            //    if (int.TryParse(Console.ReadLine(), out actionNumber))
            //    {
            //        switch (actionNumber)
            //        {
            //            case 1:
            //                int number;
            //                Console.Write("Введите число: ");
            //                // проверка введенного числа
            //                if (int.TryParse(Console.ReadLine(), out number))
            //                {
            //                    // добавление числа введенного пользователем
            //                    numbers.Add(number);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Пожалуйста, введите число!");
            //                }
            //                break;
            //            case 2:
            //                // прекращение работы
            //                isOpen = false;
            //                break;
            //            default:
            //                // некорректно введены данные
            //                Console.WriteLine("Пожалуйста, введите корректное число.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Пожалуйста, введите число!");
            //    }
            //}

            // Вызов метода для поиска наибольшего числа в списке
            //FindMaxValue(numbers, out maxNumber);

            //// Вывод результата
            //Console.WriteLine($"Максимальное значение в списке: {maxNumber}");

            // Найти делитель числа

            //int inputNumber;
            //int countDivisirs;
            //bool isOpen = true;
            //// проверка введенного числа
            //while (isOpen)
            //{
            //    Console.Write("Введите число, у которого хотите узнать количество делителей: ");
            //    // проверка введенного числа
            //    if (int.TryParse(Console.ReadLine(), out inputNumber))
            //    {
            //        // проверка числа на отрицательность 
            //        if (inputNumber < 0)
            //        {
            //            Console.WriteLine("Пожалуйста, введите положительное число или 0.");
            //            continue;
            //        }
            //        else
            //        {
            //            // Вызов метода для подсчета делителей числа
            //            CountingDivisors(inputNumber, out countDivisirs);
            //            // вывод результата
            //            Console.WriteLine($"количетсво делителей числа {inputNumber}: {countDivisirs}");
            //            isOpen = false;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Пожалуйста, введите число.");
            //    }
            //}

            // Проверка на четность с out

            //Console.Write("Введите число: ");
            //int inputNumber;
            //bool isEven;

            //// проверка введенного числа
            //if (int.TryParse(Console.ReadLine(), out inputNumber))
            //{
            //    // Вызов метода для проверки на четность, получаем булевую значение в перменной isEven
            //    isNumberEven(inputNumber, out isEven);
            //    // проверка условием для вывода результата
            //    if (isEven)
            //    {
            //        // вывод результата
            //        Console.WriteLine("число четное");
            //    }
            //    else
            //    {
            //        // вывод результата
            //        Console.WriteLine("число нечетное");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Пожалуйста, введите число");
            //}     

            // Обмен значениями двух переменных

            // иницилизация переменных
            //int a = 5;
            //int b = 10;

            //// вывод изначальных значений
            //Console.WriteLine($"a: {a}, b: {b}");
            //// вызов метода для смены значений переменных местами
            //switchPlaces(ref a, ref b);
            //// вывод результата
            //Console.WriteLine($"a: {a}, b: {b}");
        }



        // методы 

        // Изменение значения через ref

        //public static void DoubleValue(ref int value)
        //{
        //    value *= 2;
        //}

        // Метод с out для вычисления максимального значения из списка

        //public static void FindMaxValue(List<int> numbers, out int maxNumber)
        //{
        //    maxNumber = numbers[0];
        //    // перебор списка для нахождения максимального числа 
        //    foreach (var num in numbers)
        //    {
        //        if (num > maxNumber)
        //        {
        //            maxNumber = num; // обновление maxNumber, если текущий элемент больше
        //        }
        //    }
        //}

        // Найти делитель числа

        //public static void CountingDivisors(int number, out int countDivisirs)
        //{
        //    countDivisirs = 0;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        if (number % i == 0)
        //        {
        //            countDivisirs++;
        //        }
        //    }
        //}

        // Проверка на четность с out

        //public static void IsNumberEven(int number, out bool isEven)
        //{
        //    // провека на четность
        //    isEven = (number % 2 == 0);
        //}

        // Обмен значениями двух переменных

        //public static void SwitchPlaces(ref int a, ref int b)
        //{
        //    // смена значений переменных
        //    (a, b) = (b, a);
        //}
    }
}
