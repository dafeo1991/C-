// задача 1
//принимает на вход пятизначное число и проверяет, является ли оно палиндромом

// void Number (int num)
// {
//     int num5 = num % 10;
//     int num1 = num / 10000;
//     int num4 = num / 10 % 10;
//     int num2 = num / 1000 % 10; 
    
//     if (num5 == num1 && num4 == num2)
//     {
//       Console.WriteLine($"Number {num} -> palindrom");
//     }
//     else
//     {
//       Console.WriteLine($"Number {num} -> is not palindrom");
//     }
// }
// Console.WriteLine("Enter a five-digit number");
// int N = Convert.ToInt32(Console.ReadLine());
// Number (N);

//void Num (int n)
// {
//     if (n % 10 == n / 10000 && n % 100 / 10 == n / 1000 % 10  )
//     {
//         Console.WriteLine("это число палиндром");
//     }
//     else
//     {
//         Console.WriteLine("это число не палиндром");
//     }
// }
//  Console.WriteLine("введите число");
//  int num = Convert.ToInt32(Console.ReadLine());
//  Num(num);

// Задача 2
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// double GetLenght(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
//     return len;
// }

// Console.WriteLine("Введите координаты x1, y1, z1");
// double x1 = Convert.ToDouble(Console.ReadLine());
// double y1 = Convert.ToDouble(Console.ReadLine());
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты x2, y2, z2");
// double x2 = Convert.ToDouble(Console.ReadLine());
// double y2 = Convert.ToDouble(Console.ReadLine());
// double z2 = Convert.ToDouble(Console.ReadLine());
// double result = GetLenght(x1, y1, z1, x2, y2, z2);
// double result1 = Math.Round(result, 2);
// Console.WriteLine($"Расстояние между точками в 3D = {result1}");


//Задача 3 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// void Qwerty(int N)
//  {
//     Console.WriteLine($"Дано число {N} таблица кубов всех чисел от 1 до {N}");
//     for (int i = 1; i <=N; i++)
//     {
//         Console.WriteLine($"{i} -> {i*i*i}");
//     }
//  }
// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// Qwerty (N);

// void N3 (int n)
// {   
//     Console.WriteLine($"Таблица кубов чисел -> {n} ");
//     for (int i = 1; i <=n; i++)
//     {
//         Console.WriteLine(i +"->"+ i*i*i);
//     }
// }
// Console.WriteLine("Введите N");
// int num = Convert.ToInt32(Console.ReadLine());
// N3(num);

