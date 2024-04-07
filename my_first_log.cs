using System;
using System.IO;

public class Logger
{
    public static void Log(string message)
    {
        Validate(message);
        Console.WriteLine(message);
    }

    public static void LogToFile(string message)
    {
        using (StreamWriter file = new StreamWriter("filename.txt"))
        {
            file.Write(message);
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

class Program
{
    static void Main(string[] args)
    {
        Logger.Log("something is good thing");
        Logger.LogToFile("something is good thing");
    }
}
