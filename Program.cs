using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");//Obrigatório.
        Thread.Sleep(1000);
        Console.Clear();
        Menu();
    }

    static void Menu()
    {

        Console.WriteLine("Welcome to the Text Editor!");
        Console.WriteLine("Choose your option:");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1 - Open File");
        Console.WriteLine("2 - Create a new File");


        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: EditFile(); break;

            default: Menu(); break;
        }
    }


    public static void OpenFile()
    { }

    public static void EditFile()
    {
        Console.Clear();
        Console.WriteLine("Type your text bellow (ESC to finish)");
        Console.WriteLine("-----------------------------------");

        string textUser = "";// Every text will be stored here.

        while (Console.ReadKey().Key != ConsoleKey.Escape)// if user press ESC, the loop will stop.
        {
            //the function is being thought about how to do it!.
        }






    }
}
