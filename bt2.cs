
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine()!);

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Tong = {a + b}");
        Console.WriteLine($"Hieu = {a - b}");
        Console.WriteLine($"Tich = {a * b}");

        if (b != 0)
        {
            Console.WriteLine($"Thuong = {(double)a / b}");
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0!");
        }
    }
}
