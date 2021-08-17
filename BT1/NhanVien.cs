using System;
using System.Collections.Generic;
using System.Text;

namespace BT1
{
    class NhanVien : CanBo
    {
        string congviec;

        //thong tin nhan vien phuc vu
        public new void nhapThongTin()
        {
            base.nhapThongTin();
            Console.WriteLine("\nNhap cong viec: ");
            congviec = Console.ReadLine();
        }
        //hien thi thong tin nhan vien phuc vu
        public new void hienthiThongTin()
        {
            Console.WriteLine("=======================");
            base.hienthiThongTin();
            Console.WriteLine("\nCong viec cua nhan vien phuc vu: ", congviec);
        }
    }
}
