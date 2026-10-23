
using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student
        {
            Name = "Bao",
            Age = 19
        };

        s.DisplayInfo();
    }
}
