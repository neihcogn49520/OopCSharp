using System;

namespace BT1
{
    class QLCB
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========QUAN LY CAN BO==========\n");
            CongNhan[] cn;
            KySu[] ks;
            NhanVien[] nv;
            int n; //so luong can bo
            int loai; //chon loai can bo
            int c; //chon chuc nang
            Console.WriteLine("\n===========MENU===========");
            do
            {
                //menu chuong trinh
                Console.WriteLine("\n1. Cong nhan_________________");
                Console.WriteLine("\n2. Ky su_____________________");
                Console.WriteLine("\n3. Nhan vien_________________");
                Console.WriteLine("\n4. Thoat chuong trinh________");
                Console.WriteLine("\nNhap loai can bo: ");
                loai = Convert.ToInt32(Console.ReadLine());
                switch (loai)
                {
                    case 1:
                        Console.WriteLine("\n=======CONG NHAN=======");
                        Console.WriteLine("\nNhap so luong cong nhan: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        cn = new CongNhan[n];
                        Console.WriteLine("\n============CHUC NANG============");
                        Console.WriteLine("\n1. Nhap thong tin cong nhan_________________");
                        Console.WriteLine("\n2. Hien thi thong tin cong nhan_____________");
                        Console.WriteLine("\nNhap chuc nang: ");
                        c = Convert.ToInt32(Console.ReadLine());

                        switch (c)
                        {
                            case 1:
                                Console.WriteLine("**********************");
                                for (int i = 0; i < n; i++)
                             
                                {
                                    cn[i] = new CongNhan();
                                    Console.WriteLine("\nNhap thong tin cong nhan thu {0}: ", i + 1);
                                    cn[i].nhapThongTin();
                                }
                                break;
                            case 2:
                                Console.WriteLine("**********************");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("\nThong tin cong nhan thu {0}: ", i + 1);
                                    cn[i].hienthiThongTin();
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n=======KY SU=======");
                        Console.WriteLine("\nNhap so luong ky su: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        ks = new KySu[n];
                        Console.WriteLine("\n============CHUC NANG============");
                        Console.WriteLine("\n1. Nhap thong tin ky su_________________");
                        Console.WriteLine("\n2. Hien thi thong tin ky su_____________");
                        Console.WriteLine("\nNhap chuc nang: ");
                        c = Convert.ToInt32(Console.ReadLine());

                        switch (c)
                        {
                            case 1:
                                Console.WriteLine("**********************");
                                for (int i = 0; i < n; i++)
                                {
                                    ks[i] = new KySu();
                                    Console.WriteLine("\nNhap thong tin ky su thu {0}: ", i + 1);
                                    ks[i].nhapThongTin();
                                }
                                break;
                            case 2:
                                Console.WriteLine("**********************");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("\nThong tin ky su thu {0}: ", i + 1);
                                    ks[i].hienthiThongTin();
                                }
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n=======NHAN VIEN=======");
                        Console.WriteLine("\nNhap so luong nhan vien: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        nv = new NhanVien[n];
                        Console.WriteLine("\n============CHUC NANG============");
                        Console.WriteLine("\n1. Nhap thong tin nhan vien_________________");
                        Console.WriteLine("\n2. Hien thi thong tin nhan vien_____________");
                        Console.WriteLine("\nNhap chuc nang: ");
                        c = Convert.ToInt32(Console.ReadLine());

                        switch (c)
                        {
                            case 1:
                                Console.WriteLine("**********************");
                                for (int i = 0; i < n; i++)
                                {
                                    nv[i] = new NhanVien();
                                    Console.WriteLine("\nNhap thong tin nhan vien thu {0}: ", i + 1);
                                    nv[i].nhapThongTin();
                                }
                                break;
                            case 2:
                                Console.WriteLine("**********************");
                                Console.WriteLine("\nHien thi thong tin nhan vien: ");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.WriteLine("\nThong tin nhan vien thu {0}: ", i + 1);
                                    nv[i].hienthiThongTin();
                                }
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("\nLua chon khong hop le!");
                        break;
                }
            } while (!loai.Equals(4));
        }
    }
}
