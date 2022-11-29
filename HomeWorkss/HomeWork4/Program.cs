//принимает два числа, число А умножить само на себя В раз

// int Num (int A, int B)
// {   
//     int i = 1;
//     int NaturalDegree = A;
//     while (i < B)
//     {
//          NaturalDegree =  NaturalDegree * A;
//          i++;
//     }
//     return NaturalDegree;
// }

// Console.WriteLine("Iptum number A");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Iptum number B");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Num(numA, numB));

//принимает на вход число и выдаёт сумму цифр в числе.

// int Num2(int num)
// {
//     int result = 0;
//     while (num > 0 || num < 0)
//     {
//         result = result + num % 10;
//         num = num / 10;

//     }
//     return result;
// }
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Num2(num));

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] Array(int min, int max)
// {
//     int[] newArray = new int[8];
//     for (int i = 0; i < 8; i++)
//     {
//         newArray[i] = new Random().Next(min, max);
//     }
//     return newArray;
// }
// void New2(int[] array)
// {
//     Console.Write("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// Console.WriteLine("Введите число min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число max");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] myArray = Array(min, max);
// New2(myArray); 
