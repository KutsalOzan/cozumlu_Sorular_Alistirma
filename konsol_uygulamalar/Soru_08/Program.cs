namespace Soru_08;

class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo tus;
        Console.Write("Klavyeden bir tusa basiniz");
        tus = Console.ReadKey(true);
        System.Console.WriteLine();
        System.Console.WriteLine(tus.Key.ToString() + "tusuna bastiniz");
    }
}
