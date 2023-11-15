using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Switch;

internal class Program
{
    private static void Main(string[] args)
    {
        Loops_oppg();
        Console.WriteLine("___________________");
        Console.WriteLine("___________________");
        Switch_oppg();
    }

    private static void Loops_oppg()
    {
        Console.WriteLine("Oppgave 1");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Terje er kul!");
        }

        Console.WriteLine("_____________");
        Console.WriteLine("Oppgave 2");

        string word = "Blazej";
        foreach (char letter in word)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("_____________");
        Console.WriteLine("Oppgave 3");
        int x = 0;
        while (x < 10)
        {
            Console.WriteLine($"Rounde {x + 1} -- x = {x}");
            x++;
        }
    }

    private static void Switch_oppg()
    {
        Console.WriteLine("Switch oppgaver 1 og 2");
        Console.WriteLine("___________________");
        bool win = false;
        Console.WriteLine("Write 'e' or 'exit' to exit the while loop");
        Console.WriteLine("Choose num between 1 and 7");
        while (!win)
        {
            //var userInput = Convert.ToInt32(Console.ReadLine());
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                case "exit":
                    win = true;
                    break;
                case "e":
                    win = true;
                    break;
                default:
                    Console.WriteLine("Syntax error");
                    break;
            }
        }
    }
}