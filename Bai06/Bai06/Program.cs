// nhập số thực a và n tính a mũ n

using System;
namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số thực a: ");
            double a = double.Parse(Console.ReadLine()); // Nhập số thực a từ bàn phím
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine()); // Nhập số nguyên n từ bàn phím
            double result = Math.Pow(a, n); // Tính a mũ n sử dụng phương thức Math.Pow
            Console.WriteLine($"{a} mũ {n} = {result}"); // In ra kết quả
        }
    }
}