using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaMDK._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество товаров: ");
            int n = int.Parse(Console.ReadLine());

            PRICE[] prices = new PRICE[n];

            for (int i = 0; i < n; i++)
            {
                var price = new PRICE();

                Console.Write("Введите название товара: ");
                price.ProductName = Console.ReadLine();

                Console.Write("Введите цену: ");
                price.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите название магазина: ");
                price.ShopName = Console.ReadLine();

                prices[i] = price;
            }

            Console.Write("Введите название магазина, чтобы вывести информацию о товарах: ");
            string shopToSearch = Console.ReadLine();

            bool shopFound = false;

            foreach (var price in prices)
            {
                if (price.ShopName == shopToSearch)
                {
                    shopFound = true;
                    Console.WriteLine($"Магазин: {price.ShopName}, Цена: {price.Price}, Название товара: {price.ProductName}");
                }
            }

            if (!shopFound)
            {
                Console.WriteLine($"Магазин с названием {shopToSearch} не найден.");
            }

        }
    }
}
        
    

