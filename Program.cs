﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_v._1
{
    internal class Program
    {
        static void Main(string[] args)   // Можно через enum!
        {
            Console.WriteLine("Введите номер дня недели (от 1 до 7)");
            int DayOfWeek = Convert.ToInt32(Console.ReadLine());
            switch (DayOfWeek)
            {
                case 1:
                    Console.WriteLine("Сегодня понедельник");    // 1 => "Понедельник";
                    break;
                case 2:
                    Console.WriteLine("Сегодня вторник");
                    break;
                case 3:
                    Console.WriteLine("Сегодня среда");
                    break;
                case 4:
                    Console.WriteLine("Сегодня четверг");
                    break;
                case 5:
                    Console.WriteLine("Сегодня пятница");
                    break;
                case 6:
                    Console.WriteLine("Сегодня суббота");
                    break;
                case 7:
                    Console.WriteLine("Сегодня воскресенье");
                    break;
                default:
                    Console.WriteLine("Неверное число");
                    break;
            }
            Console.ReadKey(); // Сообщение для проверки работы git
        }
    }
}
