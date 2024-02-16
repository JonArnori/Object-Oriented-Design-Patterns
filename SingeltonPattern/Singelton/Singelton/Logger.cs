namespace Singelton;

using System;
using System.IO;

public class Logger
{
    private static Logger instance;
    private static readonly object lockObject = new object();
    private readonly string logFilePath;

    private Logger()
    {
        logFilePath = "application.log";
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    public void Log(string message)
    {
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}\n";
        File.AppendAllText(logFilePath, logEntry);
    }
}
