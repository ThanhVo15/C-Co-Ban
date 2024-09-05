using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Bai15
{
    class Program
    {
        static void HocList()
        {
            // Cap phat bo nho de su dung List
            List<string> ds = new List<string>();
            // them 1 phan tu vao danh sach
            ds.Add("An");
            ds.Add("Thanh");
            ds.Add("Hien");
            ds.Add("Thanh");
            ds.Add("Phuc");
            ds.Insert(2, "Nguoi thu 3");
            ds.Remove("An");

            Console.WriteLine("Danh sach cac phan tu trong List la");
            for (int i = 0; i < ds.Count; i++)
            {
                string v = ds[i];
                Console.WriteLine(v + " ");
            }
        }
        static void HocList2()
        {
            List<int> ds1 = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i <10 ; i++)
            {
                ds1.Add(rnd.Next(100));
            }
            Console.WriteLine("Cac phan tu random:");
            foreach (int i in ds1)
                Console.Write(i + " ");

            ds1.Sort();
            Console.WriteLine("\nCac phan tu random sau khi Sort:");
            foreach (int i in ds1)
                Console.Write(i + " ");

            Console.WriteLine("\nMoi ban nhap so can tim:");
            int soNhap = int.Parse(Console.ReadLine());
            
            int kq = ds1.IndexOf(soNhap);

            if (kq <0)
                Console.WriteLine("Khong tim thay so {0}", soNhap);
            else
                Console.WriteLine("Tim thay so {0} tai vi tri {1}", soNhap, kq); 
        }
        static void Main(string[] args)
        {
            //HocList();
            HocList2();
        }
    }
}