//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.  min, max + 1

// double[,] Create2DRandomArray(double min, double max, int rows, int columns)
// {
//     double[,] newArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().NextDouble() * (max - min) + min;
//             newArray[i, j] = Math.Round(newArray[i, j], 2);
//         }
//     }
//     return newArray;
// }
// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + ";" + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// double max = Convert.ToDouble(Console.ReadLine());
// Show2DArray(Create2DRandomArray(min, max, rows, columns));

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }
// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Number(int[,] array)
// {

//     Console.WriteLine("Введите индекс строки (начинайте считать с 0)");
//     int i = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите индекс столбца (начинайте считать с 0)");
//     int j = Convert.ToInt32(Console.ReadLine());
//     if (i < array.GetLength(0) && j < array.GetLength(1))
//         Console.WriteLine($"Это число {array[i, j]}");
//     else
//         Console.WriteLine($"Этого числа нет");
// }

// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] array = Create2DRandomArray(min, max, rows, columns);
// Show2DArray(array);
// Number(array);

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] Create2DRandomArray(int min, int max, int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + ";" + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Sum(int[,] array)
// {
//     Console.WriteLine("Среднее арифметическое элементов в каждом столбце -> ");
//     for (int j = 0; j < array.GetLength(0); j++)
//     {
//         double result = 0;
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             sum += array[i, j];
//             result = sum / array.GetLength(0);
//         }
//         result = Math.Round(result, 2);
//         Console.Write($"{result};  ");
//     }

// }

// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] array = Create2DRandomArray(min, max, rows, columns);
// Show2DArray(array);
// Sum(array);

 // № 1 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//  double [,] Arr (double minN, double maxN, int rows, int columns)
//  {
//     double [,] newArray = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().NextDouble()* (maxN - minN) + minN; 
//             newArray[i, j] = Math.Round(newArray[i, j], 1);
//         }
//     }
//     return newArray;
//  }
//  void V (double [,] array)
//  {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//  }
//  Console.WriteLine("Введите минимальное число");
//  double min = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Введите максимальное число ");
//  double max = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Введите количество строк");
//  int r = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите количество столбцов ");
//  int c = Convert.ToInt32(Console.ReadLine());
// double [,] myArray = Arr(min, max, r, c);
// V(myArray);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//    Console.WriteLine();
// }

// void Num (int [,] array)
// {
// Console.WriteLine("Введите i ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите j ");
// int j = Convert.ToInt32(Console.ReadLine());
// if ( i < array.GetLength(0) && j < array.GetLength(1))
// Console.WriteLine(array[i,j]);
// else Console.WriteLine("Такого числа нет");

// }


// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] array = Create2DRandomArray(min, max, rows, columns); 
// Show2DArray(array);
// Num(array);

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] Create2DRandomArray(int minValue, int maxValue, int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//    Console.WriteLine();
// }
// void Sum (int[,] array)
// {    Console.WriteLine("Среднее арифметическое элементов в каждом столбце -> ");
//     for (int j = 0; j < array.GetLength(0); j++)
// {   double result = 0;
//     double sum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         sum = sum + array[i,j];
//         result = sum / array.GetLength(0);
//     }
//     result = Math.Round(result, 2);
//     Console.Write($"{result};  ");
// }
// }

// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное число ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное число ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DRandomArray(min, max, rows, columns); 
// Show2DArray(array);
// Sum(array);

