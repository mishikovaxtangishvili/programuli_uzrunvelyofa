using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Logger.Log("something is good thing");
        Logger.LogToFile("something is good thing");
    }
}
