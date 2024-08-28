// Thuc Hanh Toan Tu Ba Ngoi ?:
double Diem;

Console.WriteLine("Moi ban nhap diem:");
Diem = double.Parse(Console.ReadLine());

string loai = (Diem >= 8 && Diem <= 10) ? "Gioi" :
    (Diem >= 6.5 && Diem < 8) ? "Kha" :
    (Diem >= 5 && Diem < 6.5) ? "Trung Binh" : "Yeu" ;

Console.WriteLine("Diem cua ban la {0}, Hoc luc:{1}", Diem, loai);




// Thuc Hanh Cau Truc Switch:
int a,b;
char kt;

Console.WriteLine("Moi ban nhap so a:");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Moi ban nhap so b:");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Moi ban nhap phep toan:");
kt = Console.ReadLine()[0];

switch (kt)
{
    case '+':
        Console.WriteLine("Day la phep cong {0} + {1} = {2}", a, b, a+b);
        break;
    case '-':
        Console.WriteLine("Day la phep tru {0} - {1} = {2}", a, b, a - b);
        break;
    case '*':
        Console.WriteLine("Day la phep nhan {0} * {1} = {2}", a, b, a * b);
        break;
    case '/':
        Console.WriteLine("Day la phep chia {0} / {1} = {2}", a, b, a / b);
        break;
    default:
        Console.WriteLine("Ban phai nhap + hoac - hoac * hoac /");
        break;
}




// Thuc Hanh Kiem tra So Ngay cua Thang
int thang, nam;

Console.WriteLine("Thang:");
thang = int.Parse(Console.ReadLine());
Console.WriteLine("Nam:");
nam = int.Parse(Console.ReadLine());

switch (thang)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("Thang nay co 31 ngay");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("Thang nay co 30 ngay");
        break;
    case 2:
        if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
            Console.WriteLine("Thang nay co 29 ngay");
        else
            Console.WriteLine("Thang nay co 28 ngay");
        break;
    default:
        Console.WriteLine("Ban nhap sai, Moi nhap lai");
        break;
}
