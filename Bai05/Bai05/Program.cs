// tính diện tích tam giác theo công thức Heron

using System;
namespace Bai05 { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập độ dài 3 cạnh của tam giác:"); //Nhập độ dài 3 cạnh của tam giác
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double p = (a + b + c) / 2; // nửa chu vi
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // công thức Heron
            Console.WriteLine($"Diện tích tam giác là: {area}");
        }
    }
}