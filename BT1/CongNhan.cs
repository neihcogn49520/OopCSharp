using System;
using System.Collections.Generic;
using System.Text;

namespace BT1
{
    class CongNhan : CanBo
    {
        string bac;

        //thong tin cong nhan
        public new void nhapThongTin()
        {
            base.nhapThongTin();
            Console.WriteLine("\nNhap bac: ");
            bac = Console.ReadLine();
        }
        //hien thi thong tin cong nhan
        public new void hienthiThongTin()
        {
            Console.WriteLine("=======================");
            base.hienthiThongTin();
            Console.WriteLine("\nCong nhan bac: ", bac);
        }
    }
}
