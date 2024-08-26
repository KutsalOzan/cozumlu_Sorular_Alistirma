internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c, d;
        int top = 0;
        int ort;
        Console.Write("1.sayiyi giriniz :");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("2.sayiyi giriniz :");
        b = Convert.ToInt16(Console.ReadLine());
        Console.Write("3.sayiyi giriniz :");
        c = short.Parse(Console.ReadLine());
        Console.Write("4.sayiyi giriniz :");
        d = short.Parse(Console.ReadLine());
        top = a + b + c + d;
        ort = top / 4;
        Console.WriteLine("Sayi Ortalamaniz {0}", ort);
    }
}