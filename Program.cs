using FirstLection.Parser;
using FirstLection.Converter;
using FirstLection.Pairarguments;

class Program
{
    private const int KToCartesian = 1;
    private const int KToPolar = 2;
    
    public static void Main(string[] args)
    {
        var parser = new Parser(args);

        Console.WriteLine($"Your input :\n" + 
                          $"First argument : {parser.FirstArgument} \n" +
                          $"Second argument : {parser.SecondArgument} \n" + 
                          $"Precision : {parser.Precision} \n");
        Console.WriteLine("Select a convert option: \n" +
                          "1.From Polar to Cartesian \n" +
                          "2.From Cartesian to Polar \n" +
                          "Default = 2 \n");

        PairArguments resultArgs;
        
        if (!int.TryParse(Console.ReadLine(), out var mode) || (mode != KToCartesian && mode != KToPolar))
        {
            mode = KToPolar;
        }

        try
        {
            resultArgs = Converter.Convert(mode, parser.FirstArgument, parser.SecondArgument);
            if (mode == KToPolar)
            {
                Console.WriteLine($"Result : r = {Math.Round(resultArgs.First, parser.Precision)}, phi = {Math.Round(resultArgs.Second, parser.Precision)} degrees");

            }
            else
            {
                Console.WriteLine($"Result : x = {Math.Round(resultArgs.First, parser.Precision)}, y = {Math.Round(resultArgs.Second, parser.Precision)}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }
}

