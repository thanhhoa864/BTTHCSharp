
//chuyển độ góc sang radian
using System;

namespace Bai02NangCao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập độ bạn muốn chuyển đổi: ");
            double doGoc = double.Parse(Console.ReadLine());

            // Công thức chuyển độ sang radian: radian = độ * (Pi / 180)
            double radian = doGoc * Math.PI / 180;

            Console.WriteLine($"{doGoc} độ tương đương với {radian:F4} radian.");
        }
    }
}