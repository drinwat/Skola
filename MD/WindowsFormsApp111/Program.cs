using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Iegūstam pašreizējo datumu un laiku
        DateTime currentTime = DateTime.Now;

        // Saglabājam datumu un laiku failā
        string filePath = "log.txt";
        string logEntry = $"Programma iedarbināta: {currentTime}";
        File.AppendAllText(filePath, logEntry + Environment.NewLine);

        // Paziņojums, ka dati ir saglabāti
        Console.WriteLine("Dati ir saglabāti failā.");

        // Pauze, lai redzētu rezultātu
        Console.ReadLine();
    }
}


