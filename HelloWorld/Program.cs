// See https://aka.ms/new-console-template for more information
namespace HelloWorld;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Type a year: ");
        var input = Console.ReadLine();
        if(input is null) return;
        int year = Int16.Parse(input);
        LeapYear leapYear = new();
        var isLeapYear = leapYear.IsLeapYear(year);
        var result = isLeapYear ? "yay" : "nay";
        Console.WriteLine(result);
    }
}

