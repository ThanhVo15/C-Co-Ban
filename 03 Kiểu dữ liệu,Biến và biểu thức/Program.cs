using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int MSSV = 12;
            double DiemC = 9.5;

            string TenBien = "Hello Word";
            string Ten = "Vo Minh Thanh";

            long DonGia = 1000000000;


            // Muon xuat ra tieng Viet thi
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Diem C: {0}", DiemC);
            Console.WriteLine("MSSV: {0} co Ten: {1} co Diem C = {2}", MSSV, Ten, DiemC);
            Console.ReadLine();
        }
    }   
}