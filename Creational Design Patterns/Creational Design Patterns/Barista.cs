using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns
{
    public class Barista
    {
        private ICoffeeBuilder coffeeBuilder;

        public Barista(ICoffeeBuilder builder)
        {
            coffeeBuilder = builder;
        }

        public void MakeCoffee()
        {
            coffeeBuilder.SetBaseCoffee("Black coffee");
        }

        public void AddMilk(string milkType)
        {
            coffeeBuilder.AddExtra(milkType);
        }

        public void AddSugar()
        {
            coffeeBuilder.AddExtra("Sugar");
        }
    }
}
