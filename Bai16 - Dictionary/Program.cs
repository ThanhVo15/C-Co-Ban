using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Bai16
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            //Dictionary<string, double> dic = new Dictionary<int, string>();
            dic.Add(1, "Vo Minh Thanh");
            dic.Add(2, "Nguyen Trung Hieu Hien");
            if (dic.ContainsKey(1) == false)
                dic.Add(2, "Ho Van Do");
            dic.Add(3, "Nguyen Van Ty");
            // để duyệt toàn bộ dữ liệu tronmg dictionary thì ta làm như sau:
            foreach ( KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine("Ma = "+item.Key+"; Ten:" +item.Value);
            }


        }
    }
}