//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

// }
// void DescendingOrder(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = 0;
//                     temp = array[i, k];
//                     array[i, k] = array[i, k + 1];
//                     array[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
// }
// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов (их должно быть меньше чем строк)");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// DescendingOrder(myArray);
// Show2DArray(myArray);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
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

// }

// void MinSumString(int[,] array)
// {
//     int min = Int32.MaxValue;
//     int count = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         if (sum < min)
//         {
//             min = sum;
//             count++;
//         }

//     }
//     Console.WriteLine("Cтрока с наименьшей суммой: " + (count));
// }


// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max);
// Show2DArray(myArray);
// Console.WriteLine();
// MinSumString(myArray);

//Напишите программу, которая заполнит спирально массив 4 на 4.

// int[,] CreateArray(int rows, int columns)
// {
//     int[,] newArray = new int[rows, columns];
//     int num = 1;
//     int i = 0;
//     int j = 0;

//     while (num <= rows * columns)
//     {
//         newArray[i, j] = num;
//         if (i <= j + 1 && i + j < rows - 1)
//             ++j;
//         else if (i < j && i + j >= columns - 1)
//             ++i;
//         else if (i >= j && i + j > rows - 1)
//             --j;
//         else
//             --i;
//         ++num;
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
// }


// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Show2DArray(CreateArray(rows, columns));

