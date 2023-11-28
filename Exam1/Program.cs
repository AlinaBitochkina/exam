using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
            //длина которых меньше, либо равна 3 символам.Первоначальный массив можно ввести с клавиатуры,
            //либо задать на старте выполнения алгоритма.
            //
            //При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


            Console.WriteLine("Введите массив:\n");
            string input = Console.ReadLine();
            string[] array = input.Split(' ');

            string[] newArray = new string[array.Length];
            int count = 0;
            
            foreach (string str in array)
            {
                if (str.Length <= 3)
                {
                    newArray[count] = str;
                    count++;
                }
            }

            // Вывод результатов
            Console.WriteLine("Новый массив:");
            Array.Resize(ref newArray, count);
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
    
}

