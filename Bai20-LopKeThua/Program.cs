using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_LopKeThua
{
    class Program
    {
        static void TestNhanVien()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            teo.ma = 1;
            teo.ten = "Nguyen Van Teo";
            Console.WriteLine("Nhan vien " + teo.ten + " =");
            teo.TinhLuong();

            NhanVienThoiVu ty = new NhanVienThoiVu();
            ty.ma = 2;
            ty.ten = "Nguyen Van Ty";
            Console.WriteLine("Nhan vien: " + ty.ten + " =");
            ty.TinhLuong();
        }
        static void TestNhanVien2()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            int luong = teo.Tinhluong(20);
            Console.WriteLine("Luong cua teo la: {0}", luong);
        }
        static void TestHinhHoc()
        {
            HinhHoc h = new HinhHoc();
            Console.WriteLine("Dien tich: " + h.TinhDienTich());

            h = new HinhTron();
            Console.WriteLine("Dien tich: " + h.TinhDienTich());
        }
        static void TestHCNvsHV()
        {
            HinhChuNhat a = new HinhChuNhat(4, 10);

            Console.WriteLine("Dien tich: " + a.DienTich());
            Console.WriteLine("Chu Vi: " + a.ChuVi());

            HinhChuNhat b = new HinhVuong(7);

            Console.WriteLine("Dien tich: " + b.DienTich());
            Console.WriteLine("Chu Vi: " + b.ChuVi());
        }
        static void TestInterface()
        {
            ILamViec teo = new NhanVien();
            Console.WriteLine(teo.LamViec("Bao cao Kinh Doanh"));

            ILamViec ty = new SinhVien();
            Console.WriteLine(ty.LamViec("DANG HOC BAI c#"));
        }
        static void Test_a_vs_is()
        {
            ILamViec teo = new NhanVien();
            if (teo is NhanVien)
            {
                Console.WriteLine("Teo la Nhan Vien");
            }

            ILamViec ty = new SinhVien();
            if (ty is SinhVien)
            {
                Console.WriteLine("Teo la Sinh Vien");
            }
        }
        static void Main(string[] args)
        {
            //TestNhanVien();
            //TestNhanVien2();
            //TestHinhHoc();
            //TestHCNvsHV();
            //TestInterface();
            Test_a_vs_is();
        }
    }
}
