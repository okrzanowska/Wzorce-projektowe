using System;

public interface IOldLogger
{
    void LogMessage(string msg);
}

public class ThirdPartyNewLogger
{
    public void WriteLog(string text, int severity)
    {
        Console.WriteLine($"Log (severity {severity}): {text}");
    }
}

public class LoggerAdapter : IOldLogger
{
    private ThirdPartyNewLogger newLogger;

    public LoggerAdapter(ThirdPartyNewLogger newLogger)
    {
        this.newLogger = newLogger;
    }

    public void LogMessage(string msg)
    {
        int defaultSeverity = 1;
        newLogger.WriteLog(msg, defaultSeverity);
    }
}

// Kod testowy
public class Program
{
    public static void Main(string[] args)
    {
        ThirdPartyNewLogger newLogger = new ThirdPartyNewLogger();
        IOldLogger logger = new LoggerAdapter(newLogger);

        logger.LogMessage("Testowy komunikat");
    }
}