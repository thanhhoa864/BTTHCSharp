//chuyển giây sang giờ, phút, giây

using System;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số giây: ");
            int totalSeconds = int.Parse(Console.ReadLine()); // Nhập số giây từ người dùng
            int hours = totalSeconds / 3600; // Tính số giờ
            int minutes = (totalSeconds % 3600) / 60; // Tính số phút
            int seconds = totalSeconds % 60; // Tính số giây còn lại
            Console.WriteLine($"{totalSeconds} giây = {hours} giờ, {minutes} phút, {seconds} giây"); // In ra kết quả
        }
    }
}