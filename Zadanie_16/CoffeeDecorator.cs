using System;

public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Prosta kawa";
    public double GetCost() => 5.0;
}

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string GetDescription() => coffee.GetDescription();
    public virtual double GetCost() => coffee.GetCost();
}

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => coffee.GetDescription() + ", Mleko";
    public override double GetCost() => coffee.GetCost() + 1.5;
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => coffee.GetDescription() + ", Cukier";
    public override double GetCost() => coffee.GetCost() + 0.5;
}

public class CreamDecorator : CoffeeDecorator
{
    public CreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => coffee.GetDescription() + ", Śmietanka";
    public override double GetCost() => coffee.GetCost() + 2.0;
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} zł");

        coffee = new MilkDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} zł");

        coffee = new SugarDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} zł");

        coffee = new CreamDecorator(coffee);
        Console.WriteLine($"{coffee.GetDescription()} - {coffee.GetCost()} zł");
    }
}
