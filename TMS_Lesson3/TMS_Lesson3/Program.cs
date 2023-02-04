using System;

namespace TMS_Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int number_t1;
            string result_t1;

            Console.WriteLine("Введите номер месяца (1-12): ");
            number_t1 = Convert.ToInt32(Console.ReadLine());

            switch (number_t1) 
            {
                case 3:
                case 4:
                case 5:
                    result_t1 = "весна";
                    break;
                case 6:
                case 7:
                case 8:
                    result_t1 = "лето";
                    break;
                case 9:
                case 10:
                case 11:
                    result_t1 = "осень";
                    break;
                case 1:
                case 2:
                case 12:
                    result_t1 = "зима";
                    break;
                default:
                    result_t1 = "неизвестен";
                    break;
            }

            Console.WriteLine($"Сезон года: {result_t1}");
            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task 2
            int number_t2;
            string result_t2;

            Console.WriteLine("Введите номер месяца (1-12): ");
            number_t2 = Convert.ToInt32(Console.ReadLine());

            if (number_t2 == 1 || number_t2 == 2 || number_t2 == 12)
            {
                result_t2 = "зима";
            }
            else if (number_t2 == 3 || number_t2 == 4 || number_t2 == 5)
            {
                result_t2 = "весна";
            }
            else if (number_t2 == 6 || number_t2 == 7 || number_t2 == 8)
            {
                result_t2 = "лето";
            }
            else if (number_t2 == 9 || number_t2 == 10 || number_t2 == 11)
            {
                result_t2 = "осень";
            }
            else
            {
                result_t2 = "неизвестен";
            }

            Console.WriteLine($"Сезон года: {result_t2}");
            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task 3
            int number_t3;
            string result_t3;

            Console.WriteLine("Введите число: ");
            number_t3 = Convert.ToInt32(Console.ReadLine());

            result_t3 = number_t3 % 2 == 0 ? "четное" : "нечетное";

            Console.WriteLine($"Число {number_t3} - {result_t3}");
            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task 4
            int number_t4;
            string result_t4 = string.Empty;

            Console.WriteLine("Введите значение температуры: ");
            number_t4 = Convert.ToInt32(Console.ReadLine());

            if (number_t4 > -5)
            {
                result_t4 = "Тепло";
            }

            if (number_t4 > -20 && number_t4 <= -5)
            {
                result_t4 = "Нормально";
            }

            if (number_t4 <= -20)
            {
                result_t4 = "Холодно";
            }

            Console.WriteLine(result_t4);
            Console.WriteLine("\nДля перехода к следующему заданию нажмите Enter");
            Console.ReadLine();

            //task 5
            int number_t5;
            string result_t5;

            Console.WriteLine("Введите число (1-7): ");
            number_t5 = Convert.ToInt32(Console.ReadLine());

            switch (number_t5)
            {
                case 1:
                    result_t5 = "красный";
                    break;
                case 2:
                    result_t5 = "оранжевый";
                    break;
                case 3:
                    result_t5 = "желтый";
                    break;
                case 4:
                    result_t5 = "зеленый";
                    break;
                case 5:
                    result_t5 = "голубой";
                    break;
                case 6:
                    result_t5 = "синий";
                    break;
                case 7:
                    result_t5 = "фиолетовый";
                    break;
                default:
                    result_t5 = "неизвестен";
                    break;
            }

            Console.WriteLine($"Цвет радуги: {result_t5}");
            Console.ReadLine();
        }
    }
}