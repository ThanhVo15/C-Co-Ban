using System;
using System.Security.Cryptography;

namespace Bai10
// Mô tả Game: Máy tính ra 1 số bất kỳ trong đoạn [0...500], người chơi sẽ tiến hành đoán số máy ra, chỉ được phép đoán sai tối đa 7 lần. Mỗi lần đoán sai thì phải thông báo cho người chơi biết là số người đoán nhỏ hơn hay lớn hơn số của máy. Sau khi kết thúc Game (thắng hoặc thua do đoán sai quá 7 lần) thì hỏi người chơi có tiếp tục hay không.
{
    class Program
    {
        static void GameDoanSo()
        {
            Random rnd = new Random();
            int x = rnd.Next(501);
            int count = 1;
            bool correctGuess = false;
            
            while ( count <= 7)
            {
                Console.WriteLine("Moi ban nhap so du doan:");
                int a = int.Parse(Console.ReadLine());
                count ++;

                if (a == x)
                {
                    Console.WriteLine("Ban da doan dung so {0} voi {1} lan", x, count);
                    correctGuess = true;
                    break;
                }
                else
                {
                    if (a<x)
                    {
                        Console.WriteLine("So ban nhap BE hon so Random");
                    }
                    else
                    {
                        Console.WriteLine("So ban nhap LON hon so Random");
                    }
                    if (count <7)
                    {
                        Console.WriteLine("Ban con {0} lan doan nua", 7 - count);
                    }
                }

            }
            if (!correctGuess)
            {
                Console.WriteLine("Ban da doan sai 7 lan, so dung la {0}", x);
                Console.WriteLine("So cua may la {0}", x);
            }
        }
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                GameDoanSo();
                Console.WriteLine("Ban co muon choi lai khong? (Y/N)");
                string ans = Console.ReadLine().ToUpper();
                if (ans != "Y")
                {
                    playAgain = false;
                }

            }
        }
    }
}