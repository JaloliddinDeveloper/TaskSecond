//Calculator
Console.Write("a=");
double a = double.Parse(Console.ReadLine());
Console.Write("b=");
double b = double.Parse(Console.ReadLine());
Console.Write("Operation: ");
string operation = Console.ReadLine();
Console.WriteLine(Calculate.CalculateMethod(a, b, operation));

//1 - n gacha bo'lgan sonlar yig'indisini hisoblash
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Calculate.SumMethod(n));

//Tub son tekshiruvi
Console.Write("t=");
int t = int.Parse(Console.ReadLine());
Console.WriteLine(Calculate.IsPrime(t));


////Basic.Ketma - ketlik bo'limi uchun 3-amaliy vazifa
///
////1.Tub sonlar ketma-ketligi
//Console.Write("N=");
//int n=int.Parse(Console.ReadLine());
//int s = 0;
//Console.Write($"{n} sonigacha bo'lgan tub sonlar ro'yxati: ");
//for (int i=0; i<=n; i++)
//{
//    for (int j=1; j<=n; j++)
//    {
//        if(i%j==0)
//        {
//            s++;
//        }
//    }
//    if(s==2)
//    {

//        Console.Write(i+ " ");
//    }
//    s = 0;
//}


////2.Berilgan sonning bo'luvchilari
//Console.Write("N=");
//int n = int.Parse(Console.ReadLine());
//Console.Write($"{n} sonning bo'luvchilari: ");
//for (int i = 2; i <= 10; i++)
//{
//    if(n%i == 0)
//    {
//        Console.Write(i+" ");
//    }
//}


////3.Berilgan sonning darajasini hisoblash
//Console.Write("Sonni Kiriting N=");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Darajani kiriting k=");
//int k = int.Parse(Console.ReadLine());
//int p = 1;
//for (int i = 1; i <= k; i++)
//{
//    p = p * n;
//}
//Console.WriteLine($"{n} sonning {k}-darajasi {n}^{k}={p}");


////4.Harajatlar to'plamini hisoblash
//Console.Write("Harajatlar sonini kiriting: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Har bir harajatning summasini kiriting: ");
//decimal s = 0;
//decimal[] Harajatlar = new decimal[100];
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"{i}- harajatning summasini kiriting: ");
//    Harajatlar[i] = decimal.Parse(Console.ReadLine());
//    s = s + Harajatlar[i];
//}
//Console.WriteLine($"Siz qilgan jami harajatlar Miqdori: {s}");


////5.Armstrong sonlar
//Console.Write("N=");
//int n = int.Parse(Console.ReadLine());
//int o = n;
//int t=CalculateNumberDigit(n);
//double s = 0;
//while (n != 0)
//{
//    int k = n % 10;
//    s = s + Math.Pow(k,t);
//    n = n / 10;
//}
//if(s == o)
//  Console.WriteLine($"{o} soni ArmStrong son ");
//else
//    Console.WriteLine($"{o} soni ArmStrong son emas ");
//int CalculateNumberDigit(int number)
//{
//    int s = 0;
//    while (number > 0)
//    {
//        number = number / 10;
//        s++;
//    }
//    return s;
//}

////6.Berilgan sonning bo'luvchilari sonini topish

//Console.Write("N=");
//int n=int.Parse(Console.ReadLine());
//int s = 0;
//for(int i=1; i<=n; i++)
//{
//    if(n%i==0)
//    {
//        s++;

//        Console.WriteLine(i + " ");
//    }
//}
//Console.WriteLine($"{n} sonning bo'luvchilari soni {s} ta ekan");
