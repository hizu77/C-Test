namespace FirstLection.Converter;
using System;
using FirstLection.Pairarguments;

public class Converter
{
    public static PairArguments Convert(int mode, double first, double second)
    {
        return mode == 2 ? ConvertToPolarFromCartesian(first, second) : ConvertToCartesianFromPolar(first, second);
    }
    
    private static PairArguments ConvertToCartesianFromPolar(double radius, double angle)
    {
        var radians = angle * Math.PI / 180;
        var x = Math.Cos(radians) * radius;
        var y = Math.Sin(radians) * radius;
        
        return new PairArguments(x, y);
    }


    private static PairArguments ConvertToPolarFromCartesian(double x, double y)
    {
        if (x == 0 && y == 0)
        {
            throw new ArgumentException("When x = 0 and y = 0 phi is undefined");
        }
        
        var radius = Math.Sqrt(x * x + y * y);
        var phi = Math.Atan2(y, x) * (180 / Math.PI);

        if (phi < 0)
        {
            phi += 360;
        }
        
        return new PairArguments(radius, phi);
    }
}