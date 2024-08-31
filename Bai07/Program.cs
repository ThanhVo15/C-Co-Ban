namespace Bai07
{
    class Program
    {
        static void HocDoWhile()
        {
            int n;
            Console.WriteLine("Moi ban nhap so giai thua can tinh (1):");
            n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i = 1;
            do
            {
                gt *= i;
                i++;
            } while (i <= n);
            Console.WriteLine("{0}! = {1}", n, gt);
        }
        static void HocWhile()
        {
            int n;
            Console.WriteLine("Moi ban nhap so giai thua can tinh (2):");
            n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i = 1;
            while (i <= n)
            {
                gt *= i;
                i++;
            };
            Console.WriteLine("{0}! = {1}", n, gt);
        }
        static void HocFor()
        {
            int n;
            Console.WriteLine("Moi ban nhap so giai thua can tinh (3):");
            n = int.Parse(Console.ReadLine());
            int gt = 1;
            int i;

            for (i = 1; i <= n; i ++)
            {
                gt *= i;
            }

            Console.WriteLine("{0}! = {1}", n, gt);
        }
        static void Main(string[] args)
        {
            //HocDoWhile();
            //HocWhile();
            HocFor();
        }
    }
}