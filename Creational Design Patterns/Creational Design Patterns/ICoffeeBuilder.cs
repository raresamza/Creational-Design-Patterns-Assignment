using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Design_Patterns
{
    public interface ICoffeeBuilder
    {
        void SetBaseCoffee(string baseCoffee);
        void AddExtra(string extra);
        Coffee GetCoffee();
    }
}
