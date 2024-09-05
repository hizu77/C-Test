namespace FirstLection.Parser;
using System;

public class Parser
{
    public Parser(string[] commandLine)
    {
        try
        {
            var firstArgument = commandLine[0];
            var secondArgument = commandLine[1];
            var precision = commandLine[2];

            FirstArgument = double.Parse(firstArgument);
            SecondArgument = double.Parse(secondArgument);
            Precision = int.Parse(precision);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid argument format.");
            throw;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid command line format.");
            throw;
        }
    }
    
    public int Precision { get; private set; }
    public double FirstArgument { get; private set; }
    public double SecondArgument { get; private set; }
}