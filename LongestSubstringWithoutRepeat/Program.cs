// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        var inputString = "abba";
        var SubFinder = new SubstringFinder();
        Console.WriteLine($"length of non repeating substring is {SubFinder.FindSubstring(inputString)}");
        Console.WriteLine($"New function result: {SubFinder.FindIndexInString(inputString)}");
    }
}