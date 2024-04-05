//using Creational_Design_Patterns;

////implement factory then builder on top of it to get correct functionality.
////this is only base.

//var builder = new CoffeeBuilder();

//var barista = new Barista(builder);

//barista.MakeCoffee();
//barista.AddMilk("Soy milk");
//barista.AddSugar();

//var customCoffee = builder.GetCoffee();

//Console.WriteLine("Custom Coffee:");
////customCoffee.Display();

using System;

public interface ICoffee
{
    void Prepare();
}

public class Espresso : ICoffee
{
    public void Prepare()
    {
        Console.WriteLine("Making Espresso: Black coffee");
    }
}

public class Cappuccino : ICoffee
{
    public void Prepare()
    {
        Console.WriteLine("Making Cappuccino: Black coffee + Milk");
    }
}

public class FlatWhite : ICoffee
{
    public void Prepare()
    {
        Console.WriteLine("Making Flat White: Black coffee + Black coffee + Milk");
    }
}

public class CoffeeMaker
{
    private ICoffeeBuilder _builder;

    public CoffeeMaker(ICoffeeBuilder builder)
    {
        _builder = builder;
    }

    public void MakeCoffee()
    {
        _builder.AddCoffee();
        _builder.AddMilk();
        _builder.AddSugar();
    }
}

public interface ICoffeeBuilder
{
    void AddCoffee();
    void AddMilk();

    void AddExtraMilk();

    void AddExtraSugar();
    void AddSugar();
    ICoffee GetResult();
}

public class CustomCoffeeBuilder : ICoffeeBuilder
{
    private ICoffee _coffee;

    public CustomCoffeeBuilder(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public void AddCoffee()
    {
        _coffee.Prepare();
    }

    public void AddMilk()
    {
        Console.WriteLine("+ Milk");
    }

    public void AddSugar()
    {
        Console.WriteLine("+ Sugar");
    }

    public ICoffee GetResult()
    {
        return _coffee;
    }

    public void AddExtraMilk()
    {
        Console.WriteLine("+ Extra Milk");
    }

    public void AddExtraSugar()
    {
        Console.WriteLine("+ Extra Sugar");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICoffee espresso = new Espresso();
        ICoffee cappuccino = new Cappuccino();
        ICoffee flatWhite = new FlatWhite();

        // Making standard coffees
        Console.WriteLine("Standard Coffees:");
        espresso.Prepare();
        cappuccino.Prepare();
        flatWhite.Prepare();

        Console.WriteLine("\nCustomized Coffees:");
        ICoffeeBuilder customBuilder = new CustomCoffeeBuilder(new FlatWhite());
        customBuilder.AddExtraMilk(); 
        customBuilder.AddExtraSugar(); 
        CoffeeMaker coffeeMaker = new CoffeeMaker(customBuilder);
        coffeeMaker.MakeCoffee();
    }
}
