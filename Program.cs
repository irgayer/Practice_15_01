using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_15_01
{
    class Program
    {
        static int ARRAY_SIZE = 10;
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите индекс числа до {ARRAY_SIZE - 1}");
            int number;

            try
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine($"Вы получили число: {GetNumber(number)}");
                }
            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("-1");
            }

            Console.WriteLine("Введите два числа: ");

            string aStr = Console.ReadLine();
            string bStr = Console.ReadLine();
            int a, b;

            if(int.TryParse(aStr, out a))
            {
                if(int.TryParse(bStr, out b))
                {
                    try
                    {
                        double result = Division(a, b);
                        Console.WriteLine($"Деление первого числа на второе = {result}");
                    }
                    catch (ArgumentException exception)
                    {
                        Console.WriteLine(exception.Message);
                        Console.WriteLine("INFINITY");
                    }
                }
            }
        }
        static int GetNumber(int index)
        {
            int[] numbers = new int[ARRAY_SIZE];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }
            if(index >= 0 && index < ARRAY_SIZE)
            {
                return numbers[index];
            }
            else
            {
                throw new IndexOutOfRangeException("ERROR\nВыход за пределы массива!");
            }
        }
        static double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("ERROR\nДеление на 0 недопустимо!");
            } 
            else
            {
                double result = a / b;
                return result;
            } 
        }
    }
}
