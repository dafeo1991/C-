/*Console.WriteLine("Input numberN");
int numN = Convert.ToInt32(Console.ReadLine());
int count = numN * -1;
while (count <= numN)
{
    Console.WriteLine(count);
    count++; 
}*/

/*Console.WriteLine("Input number N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numN % 10);*/ 

/*Console.WriteLine("Input number N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Abs(numN)%10);*/

/*Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int quad = num * num; 
Console.Write($"Quad of {num} -> {quad} ");*/

/*Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad = num2 * num2;
if (quad == num1)
{
    Console.WriteLine($"{num1} is quad of {num2}");
}
else
{
Console.WriteLine($"{num1} is not quad of {num2}");
}*/
    
/*задача 1
Console.WriteLine("Input number 1");
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

/*Задача2
Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
while (max < num2)
{
max=num2;
}
    if (max < num3)
    {
        max=num3;
        Console.WriteLine($"{max} -> number Max");
    }
    else
    {
        Console.WriteLine($"{max} -> number Max");
    }*/



Console.WriteLine("Input numberN");
int numN = Convert.ToInt32(Console.ReadLine());
if (numN<0)
    if (numN % 2==(-1))
    {
    Console.WriteLine("число нечетное");
    }
    else
    {
    Console.WriteLine("Число четное");
    }   
else
{
    if (numN % 2==1)
    {
    Console.WriteLine("число нечетное");
    }
    else
    {
    Console.WriteLine("Число четное");
    }   
}
