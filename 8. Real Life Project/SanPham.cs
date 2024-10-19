using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Real_Life_Project
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonGia { get; set; }
        public string XuatXu {  get; set; }
        public DateTime HanDung { get; set; }
        public DanhMuc Nhom { get; set; }

        public override string ToString()
        {
            return this.TenSP;
        }
    }
}
