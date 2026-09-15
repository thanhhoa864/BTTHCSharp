//Nhập số thực a và số nguyên n. Tính căn bậc n của a

using System;

namespace Bai04NangCao
{
    class Program {
        public static void Main(string[] args)
        {
            Console.Write("Nhập số thực a: ");
            double a = double.Parse(Console.ReadLine()); //nhập số thực a từ bàn phím
            Console.Write("Nhập sô nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            double result = Math.Pow(a, 1.0/n); //theo công thức căn bậc n của a bằng a mũ 1/n
            Console.Write("Kết quả của căn bậc " + n + " của " + a + " là: " + result);
        }
    }
}