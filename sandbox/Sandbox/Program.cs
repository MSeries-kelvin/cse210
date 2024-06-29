using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // the student instance automatically has the GetName() method!
        Student student = new Student();
        string name = student.GetName();
        Console.WriteLine(name);
    }
}

// a regular class called Person
public class Person
{
    public string GetName()
    {
        return "Joseph";
    }
}

// a class that inherits from Person
public class Student : Person
{
    public string GetNumber()
    {
        return "0123456789";
    }
}