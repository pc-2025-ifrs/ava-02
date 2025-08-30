// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


record Rating(byte Stars)
{

    public static bool operator >(Rating a, Rating b) => a.Stars > b.Stars;
    public static bool operator <(Rating a, Rating b) => a.Stars < b.Stars;

    public static bool operator >=(Rating a, Rating b) => a.Stars >= b.Stars;
    public static bool operator <=(Rating a, Rating b) => a.Stars <= b.Stars;
}