using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            MyMatrix matrix = new MyMatrix();
            matrix.ShowMainMatrix();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Кількість рядків нової матриці: ");
                Int32.TryParse(Console.ReadLine(), out rows);
                Console.WriteLine("Кількість стовпців нової матриці: ");
                Int32.TryParse(Console.ReadLine(), out columns);
                matrix.ShowNewMatrix(rows, columns);
                Console.WriteLine();
            }
        }
    }
}
