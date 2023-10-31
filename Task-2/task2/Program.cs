//using System;

//static bool IsPrime(int x)
//{
//    if (x <= 1)
//    {
//        return false;
//    }

//    if (x == 2)
//    {
//        return true;
//    }

//    if (x % 2 == 0)
//    {
//        return false;
//    }

//    for (int i = 3; i * i <= x; i += 2)
//    {
//        if (x % i == 0)
//        {
//            return false;
//        }
//    }

//    return true;
//}

//Console.Write("Eded daxil edin: ");
//int x = int.Parse(Console.ReadLine());

//if (IsPrime(x))
//{
//    Console.WriteLine("Sade eded");
//}
//else
//{
//    Console.WriteLine("Murekkeb eded");
//}

//static double CalculateAge(int[] arr)
//{
//    if(arr.Length == 0)
//    {
//        return 0;
//    }
//    double average = arr.Average();
//    return average;
//}

//int[] arr = new int[5];
//int i;
//for( i = 0; i < 5; i++)
//{
//    Console.Write("Imtahan qiymetiniz daxil edin :");
//    arr[i] = int.Parse(Console.ReadLine());
//}


//double average = CalculateAge(arr);

//if (average > 60)
//{
//    Console.WriteLine("Mezun oldunuz");
//}
//else
//{
//    Console.WriteLine("Mezun ola bilmediniz");
//}