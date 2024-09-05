using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Bai14
{
    class Program
    {
        /// <summary>
        /// Tạo một mảng M có n phần tử, sau đó:
        /// 1) Nhập giá trị ngẫu nhiên cho các phần tử trong mảng M
        /// 2) Xuất các giá trị trong mảng ra
        /// 3) Đảo ngược mảng 
        /// 4) sắp xêp mảng
        /// 5) tìm kiếm mảng
        /// 6) tính tổng các phần tử trong mảng
        /// </summary>
        static void HocMang1Chieu()
        {
            Console.WriteLine("Moi ban nhap vao so phan tu trong mang");
            int soPhanTu = int.Parse(Console.ReadLine());

            int[] M = new int[soPhanTu];
            Random rnd = new Random();
            //1 
            for ( int i = 0; i < M.Length; i++)
            {
                M[i] = rnd.Next(1000);
            }
            //2
            Console.WriteLine("Mang ngau nhien la:");
            for ( int i = 0;i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            //3
            Array.Reverse(M);
            Console.WriteLine("\nMang sau khi Reverse:");
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            //4 
            Array.Sort(M);
            Console.WriteLine("\nMang sau khi Sort:");
            for (int i = 0; i < M.Length; i++)
            {
                Console.Write(M[i] + " ");
            }
            //5 
            int Tong = 0;
            for (int i = 0; i < M.Length; i++)
            {
                Tong += M[i];
            }
            Console.WriteLine("\nTong cac phan tu trong mang: {0}", Tong);
            //6 Tim kiem mang da sap xep
            Console.WriteLine("/nMoi ban nhap vao so muon tim:");
            int soNhap = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(M, soNhap);
            if (kq <0)
                Console.WriteLine("Khong tim thay");
            else
                Console.WriteLine("So ban tim o vi tri {0}", kq);
            //7 Tim kiem mang chua sap xep
            Console.WriteLine("/nMoi ban nhap vao so muon tim:");
            int soNhap1 = int.Parse(Console.ReadLine());

            int kq1 = -1;
            for (int i = 0; i < M.Length;i++)
            {
                if (M[i] == soNhap1)
                {
                    kq1 = i;
                    break;
                }
            }
            if (kq1 < 0)
                Console.WriteLine("So {0} khong co trong mang", soNhap1);
            else
                Console.WriteLine("So {0} o vi tri so {1}", soNhap1, kq1);
        }
        static void HocMang2Chieu()
        {
            Console.WriteLine("Moi ban nhap vao so dong:");
            int soDong = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap vao so Cot:");
            int soCot = int.Parse(Console.ReadLine());

            int[,] M = new int[soDong, soCot];
            Random rnd = new Random();

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = rnd.Next(100);
                }
            }
            Console.WriteLine("Ma tran cua ban la:");
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(M[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //HocMang1Chieu();
            HocMang2Chieu();
        }
    }
}