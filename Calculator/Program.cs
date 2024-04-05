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

