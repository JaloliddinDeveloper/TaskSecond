////Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa
////1.Kalkulyator
//Console.Write("FirstNumber= ");
//double FirstNumber=double.Parse(Console.ReadLine());
//Console.Write("Operation: ");
//string operation=Console.ReadLine();
//Console.Write("SecondNumber= ");
//double SecondNumber = double.Parse(Console.ReadLine());

//var result = operation switch
//{
//    "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber+SecondNumber}",
//    "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber-SecondNumber}",
//    "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
//    "/"=> $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
//};

//Console.WriteLine(result);

////2.Raqamlar qatorining yig‘indisini hisoblash
//Console.Write("Enter N=");
//int n=int.Parse(Console.ReadLine());
//int s = 0,i=1;
//while (i<=n)
//{
//    s=s+i;
//    i++;
//}
//Console.WriteLine($"1 dan {n} gacha bo'lgan sonlar yig'indisi S={s} ga teng ekan");

////3.Tub son tekshiruvi tekshiruvi

//Console.Write("Ixtiyoriy natural son kiriting N=");
//int n = int.Parse(Console.ReadLine());
//int s = 0;
//for (int i = 1; i <=n; i++)
//{
//    if (n%i==0)
//    {
//        s++;
//    }
//}
//if (s == 2)
//{
//    Console.WriteLine($"Berilgan {n} soni tub son ekan ");
//}
//else
//{
//    Console.WriteLine($"Berilgan {n} soni tub son emas ekan ");
//}

////-------------------------------------------------------------------------

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
