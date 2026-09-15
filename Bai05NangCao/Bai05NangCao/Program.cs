/*Bài 5. Đảo số DaoSo.*
Cho số nguyên x có 4 chữ số. Hãy tìm số y là số đảo của số x, tức là số có các chữ số viết theo
thứ tự ngược lại của x.
Ví dụ: x = 1234
y = 4321 */

using System;

namespace Bai05NangCao {
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhập 1 số nguyên có bốn chữ số: ");
            int x = int.Parse(Console.ReadLine());
            // Tách 4 chữ số ban đầu
            int nghin = x / 1000;         // vd: 1234 / 1000 = 1
            int tram = (x / 100) % 10;   // vd: 12 % 10     = 2
            int chuc = (x / 10) % 10;    // vd: 123 % 10    = 3
            int donvi = x % 10;           // vd: 1234 % 10   = 4
            // Ghép lại theo thứ tự đảo ngược (4321)
            int y = donvi * 1000 + chuc * 100 + tram * 10 + nghin;
            Console.WriteLine("Đảo ngược chữ số: "+y);
        }
    }
}