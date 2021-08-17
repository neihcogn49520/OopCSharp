using System;
using System.Collections.Generic;
using System.Text;

namespace BT1
{
    class KySu : CanBo
    {
        string nganhdt;

        //thong tin ky su
        public new void nhapThongTin()
        {
            base.nhapThongTin();
            Console.WriteLine("\nNhap nganh dao tao: ");
            nganhdt = Console.ReadLine();
        }
        //hien thi thong tin ky su
        public new void hienthiThongTin()
        {
            Console.WriteLine("=======================");
            base.hienthiThongTin();
            Console.WriteLine("\nNganh dao tao cua ky su: ", nganhdt);
        }
    }
}
