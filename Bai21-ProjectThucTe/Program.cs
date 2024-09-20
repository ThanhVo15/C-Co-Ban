using Bai21_ProjectThucTe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_LopKeThua
{
    class Program
    {
        static List<PhongBan> dsPhongBan = new List<PhongBan>();
        static void TestQuanLyNhanVien()
        {
            PhongBan phongNhanSu = new PhongBan();
            phongNhanSu.MaPhongBan = 1;
            phongNhanSu.TenPhongBan = "Phong Nhan Su";
            dsPhongBan.Add(phongNhanSu);

            PhongBan phongKeToan = new PhongBan();
            phongKeToan.MaPhongBan = 2;
            phongKeToan.TenPhongBan = "Phong Ke Toan";
            dsPhongBan.Add(phongKeToan);

            NhanVien teo = new NhanVien();
            teo.MaNhanVien = 1;
            teo.TenNhanVien = "Nguyen Van Teo";
            teo.ChucVu = LoaiChucVu.TRUONG_PHONG;
            phongNhanSu.ThemNhanVien(teo);

            NhanVien ti = new NhanVien();
            ti.MaNhanVien = 2;
            ti.TenNhanVien = "Tran Thi Ti";
            ti.ChucVu = LoaiChucVu.NHAN_VIEN;
            phongNhanSu.ThemNhanVien(ti);

            NhanVien bin = new NhanVien();
            bin.MaNhanVien = 3;
            bin.TenNhanVien = "Vo Minh Bin";
            bin.ChucVu = LoaiChucVu.PHO_PHONG;
            phongKeToan.ThemNhanVien(bin);

            Console.WriteLine("Danh sach toan bo nhan vien trong cong ty:");
            foreach (PhongBan pb in dsPhongBan)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }

            NhanVien nvold = phongKeToan.TimNhanVien(3);
            if (nvold != null)
            {
                nvold.TenNhanVien = "Vo Minh Bimmmmm";
            }

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Danh sach toan bo nhan vien trong cong ty sau khi sua:");
            foreach (PhongBan pb in dsPhongBan)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
            phongNhanSu.XoaNhanVien(2);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Danh sach toan bo nhan vien trong cong ty sau khi xoa:");
            foreach (PhongBan pb in dsPhongBan)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
        }
        static void Main(string[] args)
        {
            TestQuanLyNhanVien();
        }
    }
}
