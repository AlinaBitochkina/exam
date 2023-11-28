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

