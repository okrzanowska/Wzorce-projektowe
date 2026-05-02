using System;
using System.Collections.Generic;

public class PrintSpooler
{
    private static readonly Lazy<PrintSpooler> instance =
        new Lazy<PrintSpooler>(() => new PrintSpooler());

    private readonly Queue<string> printQueue;
    private static readonly object lockObj = new object();

    private PrintSpooler()
    {
        printQueue = new Queue<string>();
    }

    public static PrintSpooler GetInstance() => instance.Value;

    public void AddJob(string job)
    {
        lock (lockObj)
        {
            printQueue.Enqueue(job);
            Console.WriteLine($"Dodano zadanie: {job}");
        }
    }

    public void ProcessJobs()
    {
        lock (lockObj)
        {
            while (printQueue.Count > 0)
            {
                string job = printQueue.Dequeue();
                Console.WriteLine($"Przetwarzanie zadania: {job}");
            }
        }
    }
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        PrintSpooler spooler = PrintSpooler.GetInstance();
        spooler.AddJob("Dokument1.pdf");
        spooler.AddJob("Dokument2.pdf");
        Console.WriteLine("Rozpoczynam przetwarzanie zadań...");
        spooler.ProcessJobs();
    }
}