// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNum (int n)
// {
//     if (n>=1)
//     {
//         ShowNum(n-1);
//         Console.Write(n + " ");

//     }

// }
// ShowNum(5);

//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumNum(int num)
// {
//     if (num != 0)
//     {
//          return SumNum(num / 10) + num % 10;
//     }
//     else
//     return num;
// }

// int sum = SumNum(456123);
// Console.WriteLine(sum);

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// void Num(int start, int finish)
// {
//     if (start != finish)
//     {
//         if (start > finish)
//         {
//             Num(start, finish + 1);
//             Console.Write(finish + " ");
//         }
//         else
//         {
//             Num(start, finish - 1);
//             Console.Write(finish + " ");
//         }
//     }
//     else Console.Write(start + " ");
// }
// Console.WriteLine("Введите начало промежутка ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конец промежутка ");
// int finish = Convert.ToInt32(Console.ReadLine());
// Num(start, finish);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int Num(int A, int B)
{
    if (B > 1)
    {
        return A * Num(A, B-1);
    }
    return A;
}
Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Num(A, B));