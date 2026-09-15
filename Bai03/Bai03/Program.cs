// Đổi sang giây

using System;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số giờ: ");
            int hours = int.Parse(Console.ReadLine()); // nhập số giờ
            Console.WriteLine("Nhập số phút: ");
            int minutes = int.Parse(Console.ReadLine()); // nhập số phút
            Console.WriteLine("Nhập số giây: ");
            int seconds = int.Parse(Console.ReadLine()); // nhập số giây
            Console.WriteLine($"Số giây = {hours * 3600 + minutes * 60 + seconds}");// in ra số giây
        }
    }
}