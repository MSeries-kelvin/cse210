using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = 0;
        int largest = 0;
        int smallestPositive = 100_000;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }

            if (num < smallestPositive && num > 0)
            {
                smallestPositive = num;
            }
        }

        int totalNumbers = numbers.Count;
        float average = ((float)sum) / totalNumbers;
        numbers.Sort();

        // print out results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"The sorted list is:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}