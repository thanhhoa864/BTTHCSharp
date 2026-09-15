//Tính khoảng cách giữa 2 điểm A(x1,y1) và B(x2,y2)

using System;

namespace Bai01NangCao
{
    class Program {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tính khoảng cách giữa 2 điểm A(x1,y1) và B(x2,y2)");
            Console.Write("Nhập x1: ");
            int x1 = int.Parse(Console.ReadLine()); //nhập x1 từ bàn phím
            Console.Write("Nhập y1: ");
            int y1=int.Parse(Console.ReadLine()); //nhập y1 từ bàn phím
            Console.Write("Nhập x2: ");
            int x2=int.Parse(Console.ReadLine()); //nhập x2 từ bàn phím
            Console.Write("Nhập y2: ");
            int y2=int.Parse(Console.ReadLine()); //nhập y2 từ bàn phím
            double khoangcach = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)); //công thức tính khoảng cách của 2 điểm
            Console.WriteLine("Khoảng cách giữa 2 điểm a và b là: " + khoangcach); //in ra khoảng cách của 2 điểm
        }
    }
}