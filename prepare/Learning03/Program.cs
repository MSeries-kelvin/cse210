using System;

class Program
{
    static void Main(string[] args)
    {
        // first requirement
        Fraction fraction1 = new Fraction();
        int fraction1Top = fraction1.GetTop();
        int fraction1Bottom = fraction1.GetBottom();
        Console.WriteLine(fraction1Top);
        Console.WriteLine(fraction1Bottom);

        Fraction fraction2 = new Fraction(6);
        int fraction2Top = fraction2.GetTop();
        int fraction2Bottom = fraction2.GetBottom();
        Console.WriteLine(fraction2Top);
        Console.WriteLine(fraction2Bottom);

        Fraction fraction3 = new Fraction(6, 7);
        int fraction3Top = fraction3.GetTop();
        int fraction3Bottom = fraction3.GetBottom();
        Console.WriteLine(fraction3Top);
        Console.WriteLine(fraction3Bottom);

        // second requirement
        fraction1.SetTop(2);
        fraction1.SetBottom(3);
        fraction1Top = fraction1.GetTop();
        fraction1Bottom = fraction1.GetBottom();
        Console.WriteLine(fraction1Top);
        Console.WriteLine(fraction1Bottom);

        fraction2.SetTop(5);
        fraction2.SetBottom(7);
        fraction2Top = fraction2.GetTop();
        fraction2Bottom = fraction2.GetBottom();
        Console.WriteLine(fraction2Top);
        Console.WriteLine(fraction2Bottom);

        fraction3.SetTop(10);
        fraction3.SetBottom(3);
        fraction3Top = fraction3.GetTop();
        fraction3Bottom = fraction3.GetBottom();    
        Console.WriteLine(fraction3Top);
        Console.WriteLine(fraction3Bottom);

        // third requirement
        Console.WriteLine();

        Fraction fraction4 = new Fraction(1);
        string fraction4String = fraction4.GetFractionalString();
        double fraction4Decimal = fraction4.GetDecimalValue();
        Console.WriteLine(fraction4String);
        Console.WriteLine(fraction4Decimal);

        Fraction fraction5 = new Fraction(5);
        string fraction5String = fraction5.GetFractionalString();
        double fraction5Decimal = fraction5.GetDecimalValue();
        Console.WriteLine(fraction5String);
        Console.WriteLine(fraction5Decimal);

        Fraction fraction6 = new Fraction(3, 4);
        string fraction6String = fraction6.GetFractionalString();
        double fraction6Decimal = fraction6.GetDecimalValue();
        Console.WriteLine(fraction6String);
        Console.WriteLine(fraction6Decimal);

        Fraction fraction7 = new Fraction(1, 3);
        string fraction7String = fraction7.GetFractionalString();
        double fraction7Decimal = fraction7.GetDecimalValue();
        Console.WriteLine(fraction7String);
        Console.WriteLine(fraction7Decimal);
    }
}