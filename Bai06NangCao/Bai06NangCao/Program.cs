/* Nhập 3 số nguyên a, b và m với điều kiện (1<= a,b <= 2.000.000.000 và 1<= m<= 45.000). 
 * Hãy tính số dư r = (a.b) mod m. */

using System;

namespace Bai06NangCao
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Nhập số nguyên a: ");
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Dữ liệu không hợp lệ. Vui lòng nhập lại số nguyên a: ");
                }
            } while (!(a >= 1 && a <= 2000000000));

            int b;
            do
            {
                Console.Write("Nhập số nguyên b: ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Dữ liệu không hợp lệ. Vui lòng nhập lại số nguyên b: ");
                }
            } while (!(b >= 1 && b <= 2000000000));

            int m;
            do
            {
                Console.Write("Nhập số nguyên m: ");
                while (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.Write("Dữ liệu không hợp lệ. Vui lòng nhập lại số nguyên m: ");
                }
            } while (!(m >= 1 && m <= 45000));

            long r = (long)a * b % m;
            Console.WriteLine("Kết quả của r là: " + r);
        }
    }
}