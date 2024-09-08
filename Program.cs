using System.Diagnostics;
using FirstLection.Converter;
using FirstLection.PairArguments;
using FirstLection.TripleArguments;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the precision");
        var precision = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Enter convert type :\n" + 
                          "1 - ToCartesianFromPolar : output = x y\n" +
                          "2 - KToPolarFromCartesian : output = radius phi\n" +
                          "3 - KToSphericalFromCartesian : output = radius theta phi\n" +
                          "4 - KToCartesianFromSpherical : output = x y z\n");
        var convertType = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Enter coordinates : 1-2 mode has 2 args, 3-4 mode has 3 args");
        var coordinates = Console.ReadLine()!.Split().Select(double.Parse).ToArray();

        if (convertType <= 2)
        {
            var result = Converter.Convert(convertType, new PairArguments(coordinates[0], coordinates[1]));
            Console.WriteLine(Math.Round(result.First, precision) + " " + Math.Round(result.Second, precision));
        }
        else
        {
            var result = Converter.Convert(convertType, new TripleArguments(coordinates[0], coordinates[1], coordinates[2]));
            Console.WriteLine(Math.Round(result.First, precision) + " | " + Math.Round(result.Second, precision) + " | " + Math.Round(result.Third, precision));
        }
        
        Console.ReadLine();
    }
}

