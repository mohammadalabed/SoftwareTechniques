internal class Program
{
    public delegate void PrintName(string f, string l);
    PrintName NameStyle = new PrintName(FirstLast);
    private static void Main(string[] args)
    {
        string fi = "Mohammad";
        string las = "Saleem";
        PrintFullName(fi, las, LastFirst);
        

    }

    public static void FirstLast(string first, string last)
    {
        Console.WriteLine($"{first} {last}");
    }
    public static void LastFirst(string first, string last)
    {
        Console.WriteLine($"{last} {first}");
    }

    public static void PrintFullName(string f, string l, PrintName print)
    {
        print(f, l);
    }
}


