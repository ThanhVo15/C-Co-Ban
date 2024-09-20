using System;
using System.Collections.Generic;

namespace Bai21_ProjectThucTe
{
    public class PhongBan
    {
        private List<NhanVien> dsNv = new List<NhanVien>();
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public NhanVien TruongPhong { get; set; }

        public bool ThemNhanVien(NhanVien nv)
        {
            // Kiểm tra nếu mã nhân viên đã tồn tại trong danh sách
            foreach (NhanVien oldNV in dsNv)
            {
                if (oldNV.MaNhanVien == nv.MaNhanVien)
                {
                    // Nếu mã nhân viên trùng, không thêm và trả về false
                    return false;
                }
            }
            // Nếu không trùng, thêm nhân viên vào danh sách
            dsNv.Add(nv);
            nv.Phong = this;
            return true;
        }

        public void XuatToanBoNhanVien()
        {
            foreach (NhanVien nv in dsNv)
            {
                Console.WriteLine(nv);
            }
        }
        public NhanVien TimNhanVien(int maNv)
        {
            foreach ( NhanVien oldNv in dsNv)
                if (oldNv.MaNhanVien == maNv)
                    return oldNv;
            return null;
        }
        public bool XoaNhanVien(int manv)
        {
            NhanVien nv = TimNhanVien(manv);
            if (nv == null)
                return false;
            dsNv.Remove(nv);
            return true;
        }
        public void SapXepNhanVien()
        {
            dsNv.Sort();
        }
    }
}
