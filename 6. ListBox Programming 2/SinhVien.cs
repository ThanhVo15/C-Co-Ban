using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._ListBox_Programming_2
{
    public class SinhVien
    {
        public int MaSinhVien { get; set; }
        public string TenSinhVien {get; set; }
        public override string ToString()
        {
            return this.MaSinhVien + " - " + this.TenSinhVien;
        }
    }
}
