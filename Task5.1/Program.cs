using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1,20);
            }
            foreach (int i in array)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\nНайбільше значення масиву: " + array.Max());
            Console.WriteLine("Найменьше значення масиву: " + array.Min());
            Console.WriteLine("Сума елементів масиву: " + array.Sum());
            Console.WriteLine("Середнє арифметичне всіх елементів: " + array.Average());
            Console.WriteLine("Непарні значення: ");
            foreach (int i in array)
            {
                if(i%2!=0)
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
