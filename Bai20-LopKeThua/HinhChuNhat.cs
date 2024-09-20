using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_LopKeThua
{
    public class HinhChuNhat
    {
        public int A {  get; set; }
        public int B { get; set; }
        public HinhChuNhat(int A, int B)
        {
            this.A = A;
            this.B = B;
        }
        public virtual int DienTich()
        {
            return A * B;
        } 
        public virtual int ChuVi()
        {
            return (A + B) * 2;
        }
    }
}
