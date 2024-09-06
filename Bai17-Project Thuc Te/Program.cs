using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Bai17
{
    /// <summary>
    /// Viết Phần mềm Demo Tra cứu từ điển Anh - Việt, có các chức năng sau:
    /// 1. Nhập từ mới vào từ điển
    /// 2. Sửa từ trong từ điển
    /// 3. Cho tra cứu từ điển: Nhập tiếng Anh ra tiếng Việt
    /// 4. Xóa từ trong từ điển
    /// 5. Nâng cao: Thay đổi cấu trúc dữ liệu để làm bổ sung tra cứu từ đồng nghĩa
    /// </summary>
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                Console.WriteLine("Ban co muon tiep tuc su dung Tu dien khong? (Y/N)");
                string phanHoi = Console.ReadLine().ToUpper();

                if (phanHoi == "N")
                    break;
                else if (phanHoi != "Y")
                    break;
            }
            Console.WriteLine("Bye Bye!");
        }

        private static void menu()
        {
            Console.WriteLine("Danh sach cac chuc nang:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Nhap tu moi");
            Console.WriteLine("2. Sua Tu");
            Console.WriteLine("3. Tra cuu Tu");
            Console.WriteLine("4. Xoa tu");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Moi ban chon chuc nang:");
            try
            {
                int chucNang = int.Parse(Console.ReadLine());
                switch (chucNang)
                {
                    case 1:
                        NhapTuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraCuuTu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    default:
                        Console.WriteLine("Ban nhap sai roi");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ban dang bi loi: " + ex.Message);
            }

        }

        private static void XoaTu()
        {
            Console.WriteLine("Moi ban nhap tu muon xoa");
            string tu = Console.ReadLine();

            if (dic.ContainsKey(tu) == false)
            {
                Console.WriteLine("May qua! Tu [{0}] khong co trong tu dien!", tu);
            }
            else
            {
                dic.Remove(tu);
                Console.WriteLine("Da xong thanh cong tu [{0}]!", tu);
            }

        }

        private static void TraCuuTu()
        {
            Console.WriteLine("Moi ban nhap tu muon Tra Cuu:");
            string tu = Console.ReadLine();

            if (dic.ContainsKey(tu)== false)
            {
                Console.WriteLine("Tu [{0}] khong co trong tu dien!", tu);
            }
            else
            {
                string tv = dic[tu];
                Console.WriteLine("Tu [{0}] co nghia la [{1}]", tu, tv);
            }
        }

        private static void SuaTu()
        {
            Console.WriteLine("Nhap tu Tieng Anh ban muon sua:");
            string tuSua = Console.ReadLine();

            if (dic.ContainsKey(tuSua) == false)
            {
                Console.WriteLine("Khong co tu [{0}] trong Tu dien", tuSua);
            }
            else
            {
                Console.WriteLine("Moi ban nhap nghia Tieng Viet moi:");
                string nghiaTuSua = Console.ReadLine();
                dic[tuSua] = nghiaTuSua;
            }
        }

        private static void NhapTuMoi()
        {
            Console.WriteLine("Moi ban nhap vao tu Tieng Anh:");
            string tuTA = Console.ReadLine();

            if (dic.ContainsKey(tuTA))
            {
                Console.WriteLine("Tu [{0}] da ton tai!", tuTA);
            }
            else
            {
                Console.WriteLine("Moi ban nhap nghia Tieng Viet:");
                string nghiaTV = Console.ReadLine();
                dic.Add(tuTA, nghiaTV);
            }
        }
    }
}