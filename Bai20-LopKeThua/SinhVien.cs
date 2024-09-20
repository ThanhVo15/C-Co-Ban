using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_LopKeThua
{
    public class SinhVien : ILamViec
    {
        public string LamViec(string mota)
        {
            string s = "Sinh Vien dang [" + mota + "]";
            return s;
        }
    }
}
