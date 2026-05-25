using System;
using System.Collections.Generic;

public interface IWeatherObserver
{
    void Update(float temperature, float humidity);
}

public class WeatherStation
{
    private List<IWeatherObserver> observers = new List<IWeatherObserver>();
    private float temperature;
    private float humidity;

    public void RegisterObserver(IWeatherObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IWeatherObserver observer)
    {
        observers.Remove(observer);
    }

    public void SetWeather(float temperature, float humidity)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity);
        }
    }
}

public class CurrentConditionsDisplay : IWeatherObserver
{
    public void Update(float temperature, float humidity)
    {
        Console.WriteLine($"Aktualne warunki: {temperature}°C, wilgotność {humidity}%");
    }
}

public class ForecastDisplay : IWeatherObserver
{
    public void Update(float temperature, float humidity)
    {
        string forecast = temperature > 20 ? "Słonecznie" : "Możliwe opady";
        Console.WriteLine($"Prognoza: {forecast}");
    }
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        WeatherStation station = new WeatherStation();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();
        ForecastDisplay forecastDisplay = new ForecastDisplay();

        station.RegisterObserver(currentDisplay);
        station.RegisterObserver(forecastDisplay);

        Console.WriteLine("--- Zmiana pogody 1 ---");
        station.SetWeather(25.0f, 65.0f);

        Console.WriteLine("--- Zmiana pogody 2 ---");
        station.SetWeather(15.0f, 80.0f);
    }
}
