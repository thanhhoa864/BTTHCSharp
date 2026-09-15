//Hàm số 1

using System;
namespace Bai03NangCao {
    class Program
    {
        static void Main()
        {
            Console.Write("Nhap x: ");
            double x = double.Parse(Console.ReadLine());

            double y1 = 4 * (x * x + 10 * x * Math.Sqrt(x) + 3 * x + 1); // Công thức tính y2

            double tuSo = Math.Sin(Math.PI * x * x) + Math.Sqrt(x * x + 1);//công thức tính tử số
            double mauSo = Math.Exp(2 * x) + Math.Cos((Math.PI / 4) * x); //Công Thức tính mẫu số
            double y2 = tuSo / mauSo; //Công thức tính y2

            Console.WriteLine($"y1 = {y1}");
            Console.WriteLine($"y2 = {y2}");
        }
    }
}