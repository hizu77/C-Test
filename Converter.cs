namespace FirstLection.Converter;
using System;
using FirstLection.PairArguments;
using FirstLection.TripleArguments;
public class Converter
{
    public static PairArguments Convert(int mode, PairArguments args)
    {
        return mode switch
        {
            1 => ConvertToCartesianFromPolar(args.First, args.Second),
            2 => ConvertToPolarFromCartesian(args.First, args.Second),
            _ => throw new ArgumentException("Invalid mode with 2 args")
        };
    }

    public static TripleArguments Convert(int mode, TripleArguments args)
    {
        return mode switch
        {
            3 => ConvertToSphericalFromCartesian(args.First, args.Second, args.Third),
            4 => ConvertToCartesianFromSpherical(args.First, args.Second, args.Third),
            _ => throw new ArgumentException("Invalid mode with 3 args")
        };
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

    private static TripleArguments ConvertToSphericalFromCartesian(double x, double y, double z)
    {
        var radius = Math.Sqrt(x * x + y * y + z * z);
        var phi = Math.Atan2(y, x) * (180 / Math.PI);
        var theta = Math.Acos(z / radius) * (180 / Math.PI);
        
        if (phi < 0)
        {
            phi += 360;
        }

        return new TripleArguments(radius, theta, phi);
    }

    private static TripleArguments ConvertToCartesianFromSpherical(double r, double theta, double phi)
    {
        var phiInRadians = phi * Math.PI / 180;
        var thetaInRadians = theta * Math.PI / 180;
        
        var x = r * Math.Sin(thetaInRadians) * Math.Cos(phiInRadians);
        var y = r * Math.Sin(thetaInRadians) * Math.Sin(phiInRadians);
        var z = r * Math.Cos(thetaInRadians);
        
        return new TripleArguments(x, y, z);
    }
}