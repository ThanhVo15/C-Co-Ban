using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Bai12
{
    class Program
    {
        static void HocBietLe1()
        {
            try
            {
                Console.WriteLine("Moi ban nhap vao Ngay/Thang/Nam sinh:");
                string s = Console.ReadLine();
                DateTime birthDay = DateTime.Parse(s);
                Console.WriteLine("Ban vua nhap nam sinh: " + birthDay.ToString("dd/MM/yyyy"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Loi hay khong Loi cung vao day");
            }
        }
        static void HocBietLe2()
        {
            Console.WriteLine("Moi ban nhap vao tu so:");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap vao mau so:");
            int mau = int.Parse(Console.ReadLine());

            if (mau ==0)
            {
                throw new ArithmeticException("Loi mau so = 0");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                HocBietLe2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}