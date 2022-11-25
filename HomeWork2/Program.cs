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