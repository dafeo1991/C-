// Задача1
// На вход координаты x и y выдает № четверти .
// int FintQuart(double x, double y)
// {
//     if (x > 0 && y > 0)
//         return 1;
//     if (x < 0 && y > 0)
//         return 2;
//     if (x < 0 && y < 0)
//         return 3;
//     if (x > 0 && y < 0)
//         return 4;
//     return 0;
// }
// Console.WriteLine("Input coordinate X");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y");
// double y = Convert.ToDouble(Console.ReadLine());
// int result = FintQuart(x,y);
// Console.WriteLine($"Quart number of our point is {result}");


// Задача 2 по заданному № четверти показывает диапазон возможных координат в четверти

// void FindCoordinats (int quart)
// {
//     if (quart < 1 || quart > 4)
//     Console.WriteLine("Такой четверти не существует");
//     if (quart == 1)
//     Console.WriteLine("Диапазон координат в I четверти (x>0; y>0)");
//     if (quart == 2)
//     Console.WriteLine("Диапазон координат в II четверти (x<0; y>0)");
//     if (quart == 3)
//     Console.WriteLine("Диапазон координат в III четверти (x<0; y<0)");
//     if (quart == 4)
//     Console.WriteLine("Диапазон координат в IV четверти (x>0; y<0)");
// }
// Console.WriteLine("Введите номер четверти: ");
// int quart = Convert.ToInt32(Console.ReadLine());
// FindCoordinats(quart);

// Задача 3 Принимаем координаты 2 точек и находим расстояние между ними в 2D пространстве

// double GetLenght(double x1, double y1, double x2, double y2)
// {
//     double len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
//     return len;
// }
// Console.WriteLine(GetLenght(7, -5, 1, 1));

// Задача 4 принимаем число, выдаем квадраты чисел от 1 до N
 
//  void Qwerty(int N)
//  {
//     Console.WriteLine($"Дано число {N} квадрат всех чисел от 1 до {N}");
//     for (int i = 1; i <=N; i++)
//     {
//         Console.WriteLine($"{i} -> {i*i}");
//     }
//  }
// Console.WriteLine("Input number N");
// int N = Convert.ToInt32(Console.ReadLine());
// Qwerty (N);




