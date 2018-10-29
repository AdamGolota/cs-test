using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            Product kg_of_apples = new Product();
            Console.WriteLine("Enter price of apples in USD:");
            kg_of_apples.PriceUSD = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of apples:");
            kg_of_apples.Amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cost in UAH: ");
            Console.WriteLine(kg_of_apples.CostUAH);
            Console.WriteLine("Cost in USD: ");
            Console.WriteLine(kg_of_apples.CostUSD);
            Console.WriteLine("Price in UAH: ");
            Console.WriteLine(kg_of_apples.PriceUAH);
            Console.ReadKey();
        }
    }
}
