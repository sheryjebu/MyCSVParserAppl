// See https://aka.ms/new-console-template for more information
using CSVParserApp.Models;

public class Program
{
    static List<PersonDetails>? list;
    static PersonDetails? person;

    public static void Main(string[] args)
    {
      
        string? filePath = null;

        Console.WriteLine("Enter the FilePath and FileName (with Extention) : ");
        //filePath = "/Users/sheryjebu/TechReturnsGIT/CSVParserApp/CSVParserApp/input.csv";//
        filePath = Console.ReadLine();

         ReadFile readFile = new ReadFile(filePath!);
         readFile.ReadFileFromPath(filePath!);

    }

}