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


// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// string num2 = Convert.ToString(num);                // создали переменную num2 типа строки и присвоили ей значение введенного числа
// if ( num2.Length > 2)                               // обращаемся к длинне переменной num2, если длинна больше 3 (индекс2 )                 
// {
//   Console.WriteLine("Figure № 3 -> " + num2[2]);    // то выводим третий элемент с индексом 2
// }
// else
// {
//   Console.WriteLine("There are no numbers");
// }

// // решение с помощью метода

// void Num(int num)
// {
//     if (num >= 1000 && num < 10000)
//     {
//         int r = num % 100;
//         int res = r / 10;
//         Console.WriteLine($"Третья цифра -> {res}");
//     }
//     if (num >= 100 && num < 1000)
//     {
//         int res = num % 10;
//         Console.WriteLine($"Третья цифра -> {res}");
//     }
//     if (num <100)
//     {
//         Console.WriteLine($"Третьей цифры нет");
//     }
//     if (num >= 10000)
//     {
//          Console.WriteLine($"Введите число меньше 10000");
//     }

// }

// Console.WriteLine($"Введите число -> ");
// int m = Convert.ToInt32(Console.ReadLine());
// Num(m);


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