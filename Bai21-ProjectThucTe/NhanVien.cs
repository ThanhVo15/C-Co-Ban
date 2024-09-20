using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21_ProjectThucTe
{
    public class NhanVien
    {
        public const long LUONG_CO_BAN = 10000000;
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public LoaiChucVu ChucVu { get; set; }
        public PhongBan Phong { get; set; }
        public long TinhLuong
        {
            get
            {
                if (ChucVu == LoaiChucVu.GIAM_DOC)
                {
                    return (long)(LUONG_CO_BAN * 1.25);  // Ép kiểu về long
                }
                if (ChucVu == LoaiChucVu.TRUONG_PHONG)
                {
                    return (long)(LUONG_CO_BAN * 1.15);  // Ép kiểu về long
                }
                if (ChucVu == LoaiChucVu.PHO_PHONG)
                {
                    return (long)(LUONG_CO_BAN * 1.05);  // Ép kiểu về long
                }
                return LUONG_CO_BAN;  // Không cần ép kiểu vì LUONG_CO_BAN đã là long
            }
        }
        public override string ToString()
        {
            return this.MaNhanVien
                + "\t" + this.TenNhanVien 
                + "\t" + this.ChucVu 
                + "\t==>" + this.TinhLuong;
        }
    }
}
