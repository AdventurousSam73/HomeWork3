using System;
using static System.Console;

namespace HomeWork3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание #1

            WriteLine("Введите число:");
            int value = int.Parse(ReadLine());
            WriteLine(value % 2 == 0 ? "Это число чётное" : "Это число нечётное");
            ReadKey();
            #endregion

            #region Задание #2

            WriteLine("Добро пожаловать в игру 21! Сколько у вас на руке карт?");
            int cardCount = int.Parse(ReadLine());
            int summ = 0;
            for (int i = 1; i <= cardCount; i++)
            {
                WriteLine($"Укажите номинал {i}-й карты");
                switch (ReadLine())
                {
                    case "1":
                        summ = summ + 1;
                        break;
                    case "2":
                        summ += 2;
                        break;
                    case "3":
                        summ += 3;
                        break;
                    case "4":
                        summ += 4;
                        break;
                    case "5":
                        summ += 5;
                        break;
                    case "6":
                        summ += 6;
                        break;
                    case "7":
                        summ += 7;
                        break;
                    case "8":
                        summ += 8;
                        break;
                    case "9":
                        summ += 9;
                        break;
                    case "J":
                        summ += 10;
                        break;
                    case "Q":
                        summ += 10;
                        break;
                    case "K":
                        summ += 10;
                        break;
                    case "T":
                        summ += 10;
                        break;
                }
            }
            WriteLine(summ == 21 ? "Вы победили! " : "Вы проиграли:(");
            WriteLine($"Вес ваших карт равен: {summ}");
            ReadKey();
            #endregion

            #region Задание #3

            bool simpleNumber = true;
            WriteLine("Введите число:");
            int number = int.Parse(ReadLine());
            int j = 2;
            while (j <= number - 1)
            {
                if (number % j == 0)
                {
                    simpleNumber = false;
                    break;
                }
                else
                {
                    j++;
                }
            }
            WriteLine(simpleNumber == false ? $"Число {number} не простое" : $"Число {number} простое");
            ReadKey();
            #endregion

            #region Задание #4

            WriteLine("Введите длину последовательности чисел");
            int lenght = int.Parse(ReadLine());
            int minValue = int.MaxValue;
            for (int k = 1; k <= lenght; k++)
            {
                WriteLine($"Введите значение {k}-го числа вашей последовательности:");
                int value_2 = int.Parse(ReadLine());
                if (value_2 < minValue)
                {
                    minValue = value_2;
                }
            }
            WriteLine($"Минимальное число последовательности: {minValue}");
            ReadKey();

            #endregion

            #region Задание #5
            Write("Укажите максимальное целое значение диапозона: ");
            int userMaxNumber = int.Parse(ReadLine());
            Random randomNumber = new Random();
            int aiNumber = randomNumber.Next(0, userMaxNumber + 1);
            int userNumber;
            string endGame;
            while (true) 
            {
                Write("Введите число: ");
                endGame = ReadLine();
                if (endGame == "")
                {
                    Write($"Жаль, что вы сдались:(\nЗагаданным числом было: {aiNumber}");
                    break;
                }
                else
                {
                    userNumber = int.Parse(endGame);
                    if (userNumber > aiNumber)
                    {
                        WriteLine("Введённое число больше загаданного. Попробуйте ещй раз!");
                    }
                    else if (userNumber < aiNumber)
                    {
                        WriteLine("Введённое число меньше загаданного. Попробуйте ещй раз!");
                    }
                    else
                    {
                        WriteLine("Мои поздравления! Вы угадали число!");
                        break;
                    }
                }
            }
            ReadKey();
            #endregion
        }
    }
}
