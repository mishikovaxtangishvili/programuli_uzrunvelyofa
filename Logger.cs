using System;
using System.IO;

public class Logger
{
    private int logLevel;
    private enum Levels
    {
        trace = 0,
        debug = 1,
        info = 2,
        warning = 3,
        error = 4,
        Fatal = 5,
    }

    public static void Log(string message)
    {
        Validate(message);
        Console.WriteLine(message);
    }

    public Logger()
    {
        logLevel = (int)Levels.trace;
    }


    public static void LogToFile(string message)
    {
        using (StreamWriter file = new StreamWriter("filename.txt"))
        {
            file.Write(message);
        }
    }
    public void trace(string message)
    {
        if (logLevel == (int)Levels.trace)
        {
            Console.WriteLine(message);
        }
    } 
    public void Debug(string message)
    {
        if (logLevel == (int)Levels.debug)
        {
            Console.WriteLine(message);
        }
    }

    public void Warning(string message)
    {
        if (logLevel == (int)Levels.warning)
        {
            Console.WriteLine(message);
        }
    }

    public void error(string message)
    {
        if (logLevel == (int)Levels.error)
        {
            Console.WriteLine(message);
        }
    }
    public void Fatal(string message)
    {
        if (logLevel == (int)Levels.Fatal)
        {
            Console.WriteLine(message);
        }
    }
    private static void Validate(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            throw new ArgumentException("Message is empty.");
        }

        foreach (char c in message)
        {
            if (!(char.IsLetter(c) || c == ' '))
            {
                throw new ArgumentException("Message contains invalid symbols.");
            }
        }
    }

}