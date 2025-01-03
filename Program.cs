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

        Console.WriteLine("Bem vindo ao Editor de Texto!");
        Console.WriteLine("Escolha a baixo a opção desejada:");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo arquivo");


        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: CreateFile(); break;

            default: Menu(); break;
        }
    }


    public static void OpenFile()
    { }

    public static void CreateFile()
    { }
}
