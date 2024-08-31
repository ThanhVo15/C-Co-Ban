using System;

namespace Bai08
{
    class Program
    {
        static int TinhGiaiThua(int n)
        {
            int gt = 1;
            for (int i = 1; i <= n; i++)
                gt *= i;
            return gt;
        }

        static string GiaiPhuongTrinhBac1(double a, double b)
        {
            if (a == 0 && b == 0)
                return "Vo So Nghiem";
            if (a == 0 && b != 0)
                return "Vo Nghiem";
            else
                return "x = " + (-b / a);
        }

        static void fn1(int a)
        {
            a += 5;
            Console.WriteLine("Gia tri cua a trong ham: {0}", a);
        }

        static void fn2(ref int b)
        {
            b += 5;
            Console.WriteLine("Gia tri cua b trong ham: {0}", b);
        }

        static void fn3(out double c)
        {
            c = 8;
            Console.WriteLine("Gia tri cua c trong ham: {0}", c);
        }

        static string GiaiPhuongTrinhBac2(out double a, out double b, out double c)
        {
            Console.WriteLine("Moi ban nhap tham so a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap tham so b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap tham so c:");
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        return "Phuong trinh co Vo So Nghiem!";
                    else
                        return "Phuong trinh Vo Nghiem!";
                }
                else
                {
                    return "Phuong trinh co nghiem duy nhat la: " + (-c / b);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    return "Phuong trinh Vo Nghiem!";
                }
                else if (delta == 0)
                {
                    return "Phuong trinh co Nghiem kep la: " + (-b / (2 * a));
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return $"Phuong trinh co 2 Nghiem phan biet la: {x1} va {x2}";
                }
            }
        }

        static void Main(string[] args)
        {
            // Ham Tinh Giai Thua
            int kq = TinhGiaiThua(5);
            Console.WriteLine("---------------------");
            Console.WriteLine("{0}! = {1}", 5, kq);

            // Ham Giai Phuong Trinh Bac 1
            Console.WriteLine("---------------------");
            string kq1 = GiaiPhuongTrinhBac1(8.5, 9.5);
            Console.WriteLine("Phuong trinh {0}x + {1} = 0", 8.5, 9.5);
            Console.WriteLine("Co Nghiem la: {0}", kq1);

            // Ham fn1
            Console.WriteLine("---------------------");
            int a = 5;
            Console.WriteLine("Gia tri cua a truoc khi goi ham: {0}", a);
            fn1(a);
            Console.WriteLine("Gia tri cua a sau khi goi ham: {0}", a);

            // Ham fn2
            Console.WriteLine("---------------------");
            int b = 5;
            Console.WriteLine("Gia tri cua b truoc khi goi ham: {0}", b);
            fn2(ref b);
            Console.WriteLine("Gia tri cua b sau khi goi ham: {0}", b);

            // Ham fn3
            Console.WriteLine("---------------------");
            double c = 5;
            Console.WriteLine("Gia tri cua c truoc khi goi ham: {0}", c);
            fn3(out c);
            Console.WriteLine("Gia tri cua c sau khi goi ham: {0}", c);

            // Ham Giai Phuong Trinh Bac 2
            Console.WriteLine("---------------------");
            double x, y, z;
            string kq2 = GiaiPhuongTrinhBac2(out x, out y, out z);
            Console.WriteLine("Phuong trinh cua ban la: {0}x^2 + {1}x + {2} = 0", x, y, z);
            Console.WriteLine(kq2);
        }
    }
}
