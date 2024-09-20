using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20_LopKeThua
{
    public class NhanVienChinhThuc :NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Day la phuong thuc tinh luong cua nhan vien chinh thuc");
        }
        public override int Tinhluong(int ngayCong)
        {
            if (ngayCong == 20)
            {
                return 10000000;
            }
            else
            {
                return base.Tinhluong(ngayCong);
            }
        }
    }
}
