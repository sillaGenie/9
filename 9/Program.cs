using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main()
        {
            int x = 0;
            int y = 0;
            Console.Write("X1:");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            Console.Write("X2:");
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
            Console.WriteLine("1-сложение\n2-вычитание\n3-умножение\n4-частное");
            int [] cod = { 1, 2, 3, 4 };
            Console.Write("Ваш выбор:");
            int choice = Convert.ToInt32(Console.ReadLine());
            choice--;
            try
            {
                switch (cod[choice])
                {
                    case 1:
                        {
                            Console.WriteLine(x + y);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(x - y);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(x * y);
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                Console.WriteLine(x / y);
                            }
                            catch (DivideByZeroException)
                            { Console.WriteLine("Деление на нуль"); }
                            break;
                        }
                }

            }
            catch (IndexOutOfRangeException)
            { Console.WriteLine("Код не найден. Введите 1,2,3 или 4"); }


        }
    }
}