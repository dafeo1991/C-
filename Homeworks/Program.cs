 /*задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее*/

/*Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
     Console.WriteLine($"{num1} > {num2}");
}
else
{
    Console.WriteLine($"{num2} > {num1}");
}*/


/*Задача2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*/

/*Console.WriteLine("Input number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number c");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);*/

/*Задача3  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). */

// не оптимальное решение
// Console.WriteLine("Input numberN");
// int numN = Convert.ToInt32(Console.ReadLine());
// if (numN<0)
//     if (numN % 2==(-1))
//     {
//     Console.WriteLine("число нечетное");
//     }
//     else
//     {
//     Console.WriteLine("Число четное");
//     }   
// else
// {
//     if (numN % 2==1)
//     {
//     Console.WriteLine("число нечетное");
//     }
//     else
//     {
//     Console.WriteLine("Число четное");
//     }   
// }
// Console.WriteLine(-5 % 2);

/*Задача 4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*/

/*Console.WriteLine("Input numberN");
int numN = Convert.ToInt32(Console.ReadLine());
int num2 = 2;
int count = 0 + num2;
while (count <= numN)
{
    Console.WriteLine(count);
    count+=2;
}*/


// ДЗ №2 
/* задание 1
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

/*int ThreeDigitNumber (int num)
{
    int sot = num % 100;
    int sot2 = sot /10;  
    return sot2;

}

int random = new Random().Next(100, 1000);
int sot2 = ThreeDigitNumber(random);
Console.WriteLine($"New version of {random} is {sot2}");*/

/*Задание 2
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

/*Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num);
if ( num2.Length > 2)
{
  Console.WriteLine("Figure № 3 -> " + num2[2]);
}
else
{
  Console.WriteLine("There are no numbers");
}*/




//Задача 3  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.WriteLine("Enter a number from 1 to 7");
int num = Convert.ToInt32(Console.ReadLine());
bool day (int num )

{
    if (num > 5 && num < 8)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine($"{day(num)}");*/




   
