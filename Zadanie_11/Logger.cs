using System;
using System.Collections.Generic;

public class Logger
{
    private static readonly Lazy<Logger> instance =
        new Lazy<Logger>(() => new Logger());

    private readonly List<string> logHistory;
    private static readonly object lockObj = new object();

    private Logger()
    {
        logHistory = new List<string>();
    }

    public static Logger GetInstance() => instance.Value;

    public void Log(string message)
    {
        lock (lockObj)
        {
            logHistory.Add(message);
            Console.WriteLine($"Log: {message}");
        }
    }

    public List<string> GetLogHistory()
    {
        lock (lockObj)
        {
            return new List<string>(logHistory);
        }
    }
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = Logger.GetInstance();
        logger.Log("Pierwszy komunikat");
        logger.Log("Drugi komunikat");
        Console.WriteLine("Historia logów:");
        foreach (var log in logger.GetLogHistory())
        {
            Console.WriteLine(log);
        }
    }
}
