using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Real_Life_Project
{
    public class DanhMuc
    {
        public string MaDM {  get; set; }
        public string TenDM { get; set; }

        public Dictionary<string, SanPham> dsSp =
            new Dictionary<string, SanPham>();
        public void ThemSanPham( SanPham sp)
        {
            if (this.dsSp.ContainsKey(sp.MaSP) == false)
                this.dsSp.Add(sp.MaSP, sp);

        }
        public Dictionary<string, SanPham> SanPhams
        {
            get { return this.dsSp; }
            set { this.dsSp = value; }
        }
        public override string ToString()
        {
            return this.TenDM;
        }
    }
}
