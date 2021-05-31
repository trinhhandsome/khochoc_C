using System;

namespace buoi2
{
    class buoi2
    {
        static void Main()
        {
            //phan1();
            //phan2();
            phan3();
        }
        static void phan1()
        {
            //các biến hằng và các toán.
            // cách in ra màn hình
            Console.WriteLine(" trinh dep trai!");
            Console.ReadLine();
            //khai báo biến
            string _trinh = "dep trai";
            int _int = 10;
            double _thuc = 9.5;
            //TH1: In chuỗi
            Console.WriteLine("Chuoi vua khai bao: " + _trinh);
            //TH2: In số thực, số nguyên
            Console.WriteLine("so vua khai bao: {0} và {1}", _int, _thuc);
            Console.ReadLine();
        }
        static void phan2()
        {
            //Nhập và đọc chuỗi vừa nhập vào màn hình.
            Console.Write("Ho và ten cua ban la gi? Ten minh là: ");
            string _HoTen = Console.ReadLine();
            Console.Write("Xin chao ban " + _HoTen + "\n");
            Console.Write("So ky tu trong ten cua ban la: {0}\n", _HoTen.Length);
            Console.Write("ho ten in thuong: {0}\n", _HoTen.ToLower());
            Console.Write("HO TEN IN HOA: {0}\n", _HoTen.ToUpper());
            Console.Write("Kiem tra co chu T: {0}", _HoTen.Contains("Tuan"));
            Console.ReadLine();
        }
        static void phan3()
        {
            //toán tử
            Console.Write("so nguyen can kiem tra la n = ");
            string _str_songuyen = Console.ReadLine();
            int _int_songuyen = int.Parse(_str_songuyen);
            //kiểm tra chẵn lẻ
            string _ketquaA = (_int_songuyen % 2 == 0) ? "so chan" : "so le";
            Console.WriteLine(" so n = {0} la {1}", _int_songuyen, _ketquaA);
            //kiểm tra âm dương
            string _ketquaB = (_int_songuyen > 0 ) ? "so duong" : "so am";
            Console.WriteLine(" so n = {0} la {1}", _int_songuyen, _ketquaB);
            Console.ReadLine();
        }
    }
}
