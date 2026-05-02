using System;

public interface IPizzaBuilder
{
    void AddDough();
    void AddMeat();
    void AddCheese();
    void AddVegetables();
    void AddSpices();
    Pizza GetPizza();
}

public class CapricciosaBuilder : IPizzaBuilder
{
    private Pizza pizza;

    public CapricciosaBuilder()
    {
        pizza = new Pizza();
    }

    public void AddDough()
    {
        pizza.Description += "Ciasto, ";
    }

    public void AddMeat()
    {
        pizza.Description += "Szynka, ";
    }

    public void AddCheese()
    {
        pizza.Description += "Ser, ";
    }

    public void AddVegetables()
    {
        pizza.Description += "Pieczarki, ";
    }

    public void AddSpices()
    {
        pizza.Description += "Przyprawy";
    }

    public Pizza GetPizza()
    {
        return pizza;
    }
}

public class Pizza
{
    public string Description { get; set; } = "Składniki: ";
}

public class Director
{
    public void Construct(IPizzaBuilder builder)
    {
        builder.AddDough();
        builder.AddMeat();
        builder.AddCheese();
        builder.AddVegetables();
        builder.AddSpices();
    }
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        Director director = new Director();
        IPizzaBuilder builder = new CapricciosaBuilder();

        director.Construct(builder);
        Pizza pizza = builder.GetPizza();

        Console.WriteLine(pizza.Description);
    }
}