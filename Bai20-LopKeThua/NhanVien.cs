using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_LopKeThua
{
    public class NhanVien:ILamViec
    {
        public int ma {  get; set; }
        public string ten { get; set; }

        public string LamViec(string mota)
        {
            string s = "Nhan Vien dang [" + mota + "]";
            return s;
        }

        public void TinhLuong()
        {
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien");
        }
        public virtual int Tinhluong(int ngayCong)
        {
            return ngayCong * 100;
        }
    }
}
