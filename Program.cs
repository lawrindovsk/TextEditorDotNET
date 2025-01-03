using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
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


#pragma warning disable CS8604 // Possível argumento de referência nula.
        short option = short.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possível argumento de referência nula.

        switch (option)
        {
            case 0: Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: CreateFile(); break;

            default: Menu(); break;
        }
    }


    public static void OpenFile()
    { }//Fuction to Open the file.

    public static void CreateFile()
    {
        Console.Clear();
        Console.WriteLine("Type your text bellow (ESC to finish)");
        Console.WriteLine("-----------------------------------");

        string textUser = "";// Every text will be stored here.

        do
        {
            textUser += Console.ReadLine(); // User text type stored here.
            textUser += Environment.NewLine; // Every time the user press ENTER, a new line will be created.
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);// if user press ESC, the loop will stop.

        SaveFile(textUser);
    }//Function to edit the file.

    public static void SaveFile(string text)
    {
        Console.Clear();
        Console.WriteLine("To you save your text file, you need to scribe a full path, like this");
        Console.WriteLine("Exemple: C:/Users/You/Desktop/yourfile.txt");
        Console.WriteLine("---------------------------------------------------------------------------");
        Thread.Sleep(9500);//Time to user read the message.
        Console.Clear();
        Thread.Sleep(2500);

        Console.WriteLine("What the path you want the save file?");// Ask to user the file name.
        var path = Console.ReadLine();

#pragma warning disable CS8604 // Possível argumento de referência nula.
        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
#pragma warning restore CS8604 // Possível argumento de referência nula.

        Console.WriteLine($"Your archive {path} was saved successfully!");
        Console.ReadLine();
        Menu();
    }//Function to save the file.




}
