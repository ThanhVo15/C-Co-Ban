using Bai19___Class;

namespace Bai19
{
    class Program
    {
        static void SinhVien()
        {
            // thuc hanh contractor mac dinh
            SinhVien SV1 = new SinhVien();
            Console.WriteLine(SV1);

            // thuc hanh get/set
            SV1.Ten = "Nguyen Trung Hieu Hien";
            SV1.Ma = 214111971;
            Console.WriteLine(SV1);

            // thuc hanh contracotr co doi so
            SinhVien SV2 = new SinhVien(214162152, "Nguyen Trung Hieu Hien");
            Console.WriteLine(SV2);

            // thuc hanh them ham kiem tra nam sinh
            SinhVien SV3 = new SinhVien();
            SV3.Ma = 123456;
            SV3.Ten = "Vo Trung Hien";
            SV3.NamSinh = new DateTime(2003, 1, 1);
            SV3.XuatThongTin();
        }
        static void TestParams()
        {
            ClassTestParams tests = new ClassTestParams();
            Console.WriteLine( tests.Sum(1,4,5667,7,5,3,3 ));
            Console.WriteLine(tests.Sum(1, 4, -5667, 7, 5, 3, 3));
        }

        static void TestKhachHang()
        {
            List<KhachHang> DSKH = new List<KhachHang>();
            DSKH.Add(new KhachHang() { Ma = "1", Ten = "Nguyen Trung Hieu Hien", Phone = 0918702900 });
            DSKH.Add(new KhachHang() { Ma = "2", Ten = "Vo Minh Thanh", Phone = 0395500288 });
            DSKH.Add(new KhachHang() { Ma = "3", Ten = "Vo Dang Minh Chau", Phone = 0817422200 });

            Console.WriteLine("Ma" + "\t" + "Ten" + "\t" + "Phone");
            foreach (KhachHang khachHang in DSKH)
            {
                Console.WriteLine(khachHang.Ma + "\t" + khachHang.Ten + "\t" + khachHang.Phone);
            }
            
        }
        static void Main(string[] args)
        {
            //TestParams();
            TestKhachHang();
        }
    }
}