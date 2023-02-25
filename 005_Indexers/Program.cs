using System;
using System.Text;

// Індексатори.

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            string languageFromTranslation, languageIntoTranslation;

            Console.WriteLine("З якої мови необхідно перекласти? (EN/RU/UA)");
            languageFromTranslation = Console.ReadLine();

            Console.WriteLine("На яку мову необхідно перекласти? (EN/RU/UA)");
            languageIntoTranslation = Console.ReadLine();
            Dictionary dictionary = new Dictionary(languageFromTranslation, languageIntoTranslation);
            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["олівець"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["sun"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
                        
            // Delay.
            Console.ReadKey();
        }
    }
}
