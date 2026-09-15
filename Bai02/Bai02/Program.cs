// Tính diện tích và chu vi hình tròn

using System;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập bán kính hình tròn: ");
            double radius = Convert.ToDouble(Console.ReadLine()); // Nhập bán kính hình tròn từ người dùng
            double area = Math.PI * Math.Pow(radius, 2); // Tính diện tích hình tròn
            double circumference = 2 * Math.PI * radius; // Tính chu vi hình tròn
            Console.WriteLine($"Diện tích hình tròn: {area}"); // In ra diện tích hình tròn
            Console.WriteLine($"Chu vi hình tròn: {circumference}");// In ra chu vi hình tròn
        }
    }
}