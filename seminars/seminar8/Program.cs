//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }
// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// int [,] ChangeRows(int[,] array, int row1, int row2)
// {
//     if (row1 > array.GetLength(0) || row2 > array.GetLength(0))
//     return array;
//     else 
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     return array;
// }
// Console.WriteLine("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первую строку которую хотите поменять ");
// int r1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите вторую строку которую хотите поменять ");
// int r2 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max);
// Show2DArray(myArray);
// myArray = ChangeRows(myArray, r1, r2);
// Console.WriteLine();
// Show2DArray(myArray);


// Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return newArray;
// }
// void Show2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int [,] DiagonalNew(int [,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Невозможно выполнить, введите квадратный массив");
//         return array;
//     }
//     else 
//     for (int i = 0; i < array.GetLength(0) - 1; i++)
//     {
//         for (int j = i+1; j < array.GetLength(0); j++)
//         {
//             int temp = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = temp;
//         }
//     }
//     return array;
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
// myArray = DiagonalNew(myArray);
// Show2DArray(myArray);

//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
  
}
int [,] FindMin (int [,] array)
{
    int row = 0;
    int columns = 0;
    int MinValue = array[row, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < MinValue)
            {
                MinValue = array[i,j];
                row = i;
                columns = j; 
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, columns] = 0;
    }
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[row, j] = 0;
    }
    
    return array;
}
Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(rows, columns, min, max);
Show2DArray(myArray);
Console.WriteLine();
myArray = FindMin(myArray);
Show2DArray(myArray);