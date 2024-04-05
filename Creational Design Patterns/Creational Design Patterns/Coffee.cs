using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns
{
    public class Coffee
    {
        public string BaseCoffee { get; set; }
        public List<string> Extras { get; set; }

        public Coffee()
        {
            Extras = new List<string>();
        }

        public void Display()
        {
            Console.WriteLine($"Base: {BaseCoffee}");
            Console.WriteLine("Extras:");
            foreach (var extra in Extras)
            {
                Console.WriteLine($"- {extra}");
            }
        }
    }
}
