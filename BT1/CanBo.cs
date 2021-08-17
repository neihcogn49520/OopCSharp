using System;
using System.Collections.Generic;
using System.Text;

namespace BT1
{
    class CanBo
    {
        public string hoten;
        public int namsinh;
        public string gioitinh;
        public string diachi;

        public void nhapThongTin()
        {
            Console.WriteLine("\nNhap ho ten can bo: ");
            hoten = Console.ReadLine();
            Console.WriteLine("\nNhap nam sinh: ");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
            Console.WriteLine("\nNhap dia chi: ");
            diachi = Console.ReadLine();
        }
        public void hienthiThongTin()
        {
            Console.WriteLine("\nHo ten: ", hoten);
            Console.WriteLine("\nNam sinh: ", namsinh);
            Console.WriteLine("\nGioi tinh: ", gioitinh);
            Console.WriteLine("\nDia chi: ", diachi);
        }
    }
}
