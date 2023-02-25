using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int index;
            string name;
            Store store = new Store(new[]
            {
                new Article("PC","Rozetka",9986),
                new Article("Phone","Comfy",4567),
                new Article("TV","Allo",2245),
                new Article("Radio","SoundMaster",897),
            });
            Console.WriteLine("Введіть номер товару: ");
            Int32.TryParse(Console.ReadLine(), out index);

            Article article = store[index];
            Console.WriteLine($"Назва товару: {article.Name}\n" +
                $"Магазин: {article.Store}\n" +
                $"Ціна: {article.Price} грн");

            Console.WriteLine("Введіть назву товару: ");
            name = Console.ReadLine();

            Article article1 = store[name];
            if(article1 != null)
            {
                Console.WriteLine($"Назва товару: {article1.Name}\n" +
               $"Магазин: {article1.Store}\n" +
               $"Ціна: {article1.Price} грн");
            }
            else
            {
                Console.WriteLine("Таких товарів немає");
            }
            Console.ReadLine();
        }
    }
}
