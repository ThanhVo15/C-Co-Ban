using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19___Class
{
    public class SanPham
    {
        private string ma;
        private string tensp;
        private int soluong;
        private double dongia;

        public SanPham(string ma, string tensp, int soluong, double dongia)
        {
            this.ma = ma;
            this.tensp = tensp;
            this.soluong = soluong;
            this.dongia = dongia;
        }

        public SanPham()
        {

        }
    }
}
