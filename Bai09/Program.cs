namespace Bai09
{
    class Program
    {
        static void TestToanHoc()
        {
            Console.WriteLine("Moi ban nhap so a:");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Can Bac 2 cua so {0} la {1}", a, Math.Sqrt(a));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Moi ban nhap so b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Luy thua cua {0}^{1} la {2}", a, b, Math.Pow(a,b));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Moi ban nhap 1 goc:");
            int goc = int.Parse(Console.ReadLine());
            double radian = (goc / 180) * Math.PI;
            Console.WriteLine("sin({0}) = {1}", goc,Math.Sin(radian));
            Console.WriteLine("cos({0}) = {1}", goc, Math.Cos(radian));
            Console.WriteLine("tan({0}) = {1}", goc, Math.Tan(radian));
            Console.WriteLine("cotan({0}) = {1}", goc, 1/ Math.Tan(radian));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Moi ban nhap 1 so de lam tron:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("So {0} lam tron se bang: {1}", x, Math.Round(x, 2));
        }

        static void TestRandom()
        {
            // hay xuat 1 so ngau nhien trong doan [0 ->100)
            Random rnd = new Random();
            int x = rnd.Next(101);
            Console.WriteLine("May output ra so ngau nhien la {0}", x);

            double y = rnd.NextDouble();
            Console.WriteLine("May output ra so ngau nhien DOUBLE la {0}", y);
        }

        static void TestDateTime()
        {
            DateTime dt = new DateTime(1970, 1, 27);
            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
            Console.WriteLine(dt.ToString("d/M/yyyy"));

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Moi ban nhap Ngay/ Thang/ Nam sinh:");
            string s = Console.ReadLine();
            DateTime birthday = DateTime.Parse(s);
            Console.WriteLine("Ban sinh vao ngay " + birthday.Day);
            Console.WriteLine("Ban sinh vao thang " + birthday.Month);
            Console.WriteLine("Ban sinh vao nam " + birthday.Year);
        }
        static void Main(string[] args)
        {
            //TestToanHoc();
            //TestRandom();
            TestDateTime();
        }
    }
}