using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace JSON2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Employees.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Products[] products = JsonSerializer.Deserialize<Products[]>(jsonString);

            Products maxPrice = products[0];
            foreach (Products e in products)
            {
                if (e.Price > maxPrice.Price)
                {
                    maxPrice = e;
                }
            }
            Console.WriteLine($"{maxPrice.Code} {maxPrice.Name} {maxPrice.Price}");
            Console.ReadKey();
        }
    }
}
