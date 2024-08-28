int a = 12;
a += 3;
Console.WriteLine("Ket Qua: {0}", a);



// Test thu 1 chuong trinh
int b;
Console.WriteLine("Moi ban nhap 1 so bat ky:");
b = int.Parse(Console.ReadLine());
if (b % 2 == 0)
    Console.WriteLine("So {0} la so Chan", b);
else
    Console.WriteLine("So {0} la so Le", b);





// Chuong trinh kiem tra xem nam nhuan hay khong
int year;
Console.WriteLine("Moi ban nhap 1 nam de kiem tra:");
year = int.Parse(Console.ReadLine());
if (year%4  == 0 && year %100 != 0 || year %400 == 0)
{
    Console.WriteLine("Nam {0} cua ban la nam Nhuan", year);
}
else
{
    Console.WriteLine("Nam {0} cua ban KHONG la nam Nhuan", year);
}
Console.ReadLine();

