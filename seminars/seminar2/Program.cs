//Находим большую цифру из числа, рандомно находим число

/*int FindBiggestDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        return ed;
    }
    else 
    {
        return dec;
    }
}

int random = new Random().Next(10, 100);
int result = FindBiggestDigit(random);
Console.WriteLine($"Your number -> {random}");
Console.WriteLine($"The biggest digit -> {result}");*/

// Вывести случайное число и удалить вторую цифру

// int CutNumber (int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     int res = sot * 10 + ed;
//     return res;
// }

// int random = new Random().Next(100, 1000);
// int NewNumber = CutNumber(random);
// Console.WriteLine($"New version of {random} is {NewNumber}");

// Принимает два числа и проверяет кратно ли второе число первому

/*void main (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine (num1 / num2);
        Console.WriteLine("Число кратно");
    }

    else
    {
        Console.WriteLine("Число не кратно -> остаток от деления");
        Console.WriteLine(num1 % num2);
    }
}
main (17, 4);*/

// принимает на вход число и проверяет кратно ли числам 7 и 23
/*bool main (int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine($"{main(161)}");*/



