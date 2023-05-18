using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    internal class cs2
    {
        public static void task_2()
        {
            string pair = "C:\\Users\\gdima\\source\\repos\\lab14\\lab14\\pair.txt";
            string nonpair = "C:\\Users\\gdima\\source\\repos\\lab14\\lab14\\nonpair.txt";
            int[] numbers = new int [10000];
            Random random = new();

            //генеруємо 10000 тисяч чисел
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }

            //розподіляєм числа по файлах
            using StreamWriter evenWriter = new(pair);
            using StreamWriter oddWriter = new(nonpair);
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenWriter.WriteLine(number);
                }
                else
                {
                    oddWriter.WriteLine(number);
                }
            }
            evenWriter.Close();
            oddWriter.Close();

            int evenCount = File.ReadAllLines(pair).Length;
            int oddCount = File.ReadAllLines(nonpair).Length;

            
            Console.WriteLine("Statistics:");
            Console.WriteLine("Total numbers: " + numbers.Length);
            Console.WriteLine("Even numbers: " + evenCount);
            Console.WriteLine("Odd numbers: " + oddCount);
        }
    }
}
