using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Bai13
{
    class Program
    {
        // Nhap vao 1 chuoi, sau do
        // 1. Dem xem chuoi co bao nhieu in HOA, in thuong, số
        // 2. Dem so khoang trang trong chuoi
        static void XuLiCHuoi1()
        {
            Console.WriteLine("Moi ban nhap vao 1 chuoi:");
            string s = Console.ReadLine();

            int inHOA = 0;
            int inthuong = 0;
            int so = 0;
            int demKhoangTrang = 0;

            char[] arr = s.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                    inHOA++;
                if (char.IsLower(arr[i]))
                    inthuong++;
                if (char.IsWhiteSpace(arr[i]))
                    demKhoangTrang++;
                if (char.IsDigit(arr[i]))
                    so++;
            }
            Console.WriteLine("Chuoi cua ban co {0} ky tu in Hoa", inHOA);
            Console.WriteLine("Chuoi cua ban co {0} ky tu in thuong", inthuong);
            Console.WriteLine("Chuoi cua ban co {0} khoang trang", demKhoangTrang);
            Console.WriteLine("Chuoi cua ban co {0} ky tu so", so);
        }
        static void XuLiCHuoi2()
        {
            Console.WriteLine("Moi ban nhap vao chuoi 1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Moi ban nhap vao chuoi 2:");
            string s2 = Console.ReadLine();

            int kq = s1.ToLower().CompareTo(s2.ToLower());

            if (kq == 0)
            {
                Console.WriteLine("2 chuoi ban nhap giong nhau");
            }
            else
            {
                Console.WriteLine("2 chuoi ban nhap khac nhau");
            }
        }
        static void XuLiCHuoi3()
        {
            string s3 = string.Format("Hien tai dang la {0: dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s3);
        }
        static void XuLiCHuoi5()
        {
            string s = "D:/Bai Hat/Nhac Trinh/dem thay ta la thac do.mp3";
            // hay tim vi tri dau tien cua ky tu /
            int vt = s.IndexOf("/");
            Console.WriteLine("Tim thay ky tu / o vi tri thu: {0}", vt);
            // hay tim vi tri cuoi cung cua ky tu /
            int vt2 = s.LastIndexOf("/");
            Console.WriteLine("Tim thay ky tu / o vi tri thu: {0}", vt2);
        }
        static void XuLiChuoi6()
        {
            string s = "D:/Bai Hat/Nhac Trinh/dem thay ta la thac do.mp3";
            string s1 = s.Substring(s.LastIndexOf("/") + 1);
            int vt = s1.IndexOf(".");
            string s2 = s1.Substring(0, vt);
            Console.WriteLine(s2);
        }
        static void XuLiChuoi7()
        {
            string s = "SV113, Vo Minh Thanh, thanhvm21416c@st.uel.edu.vn";
            string[] arr = s.Split(", ");
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
        } 
        // Cho 1 chuoi goc, yeu cau 
        // 1. Xoa cac khoang trang du thua, ben trai, ben phai chuoi
        // 2. cac tu cach nhau boi 1 khoang trang
        // 4. ky tu dau tien viet hoa
        static void ToiUuCHuoi()
        {
            Console.WriteLine("Moi ban nhap chuoi can toi uu:");
            string s = Console.ReadLine();
            Console.WriteLine("Choi ban dau ban nhap: {0}", s);

            s = s.Trim();
            string []arr = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string kq = "";
            for (int i = 0; i < arr.Length; i++)
            {
                // lay ra tung tu trong arr
                string word = arr[i];
                word = word.ToLower();
                char[] arr2 = word.ToCharArray();
                arr2[0] = char.ToUpper(arr2[0]);

                word = new string(arr2);
                kq = kq + word + " ";
            }
            Console.WriteLine(kq);
        }
        static void Main(string[] args)
        {
            //XuLiCHuoi1();
            //XuLiCHuoi2();
            //XuLiCHuoi3();
            //XuLiCHuoi5();
            //XuLiChuoi6();
            //XuLiChuoi7();
            ToiUuCHuoi();
        }
    }
}