using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19___Class
{
    public class SinhVien
    {
        #region Khai bao bien
        private int ma;
        private string ten;
        private DateTime namsinh;
        #endregion

        #region Tao Contractor
        public SinhVien()
        {
            this.ma = 214162152;
            this.ten = "Vo Minh Thanh";
        }

        public SinhVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion

        #region Tao Properties
        public int Ma
        {
            set
            {
                this.ma = value;
            }
            get
            {
                return this.ma;
            }
        }
        public string Ten
        {
            get
            {
                return this.ten;
            }
            set
            {
                this.ten= value;
            }
        }
        public DateTime NamSinh
        {
            get
            {
                return this.namsinh;
            }
            set
            {
                this.namsinh = value;
            }
        }
        #endregion
        #region Cac phuong thuc
        public override string ToString()
        {
            return this.ma + "\t" + this.ten;
        }

        private bool KiemTraHopLe()
        {
            return (DateTime.Now.Year -  this.namsinh.Year >= 17);
        }

        public void XuatThongTin()
        {
            if (KiemTraHopLe() == false)
                Console.WriteLine("Nit noi ma doi lam sinh vien");
            else
                Console.WriteLine(ToString());
        }
        #endregion
    }
}
