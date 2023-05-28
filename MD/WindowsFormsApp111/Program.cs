using System;
using System.IO;

class Program
{
    static void Main()
    {
       
        DateTime currentTime = DateTime.Now;

        string filePath = "log.txt";
        string logEntry = $"Programma iedarbināta: {currentTime}";
        File.AppendAllText(filePath, logEntry + Environment.NewLine);

        Console.WriteLine("Dati ir saglabāti failā.");

        Console.ReadLine();
    }
}


