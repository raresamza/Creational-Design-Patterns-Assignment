using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns
{
    public class CoffeeBuilder : ICoffeeBuilder
    {
        private Coffee coffee;

        public CoffeeBuilder()
        {
            coffee = new Coffee();
        }

        public void SetBaseCoffee(string baseCoffee)
        {
            coffee.BaseCoffee = baseCoffee;
        }

        public void AddExtra(string extra)
        {
            coffee.Extras.Add(extra);
        }

        public Coffee GetCoffee()
        {
            return coffee;
        }
    }
}
