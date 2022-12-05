// массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] ArrayWithNumbers(int size)

// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void QuantityNum(int[] array)
// {
//     int count = 0;
//     int num = array.Length;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;

//     }
//     Console.WriteLine($"Количество четных чисел равно -> {count}");
// }
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] newArray = ArrayWithNumbers(size);
// ShowArray(newArray);
// QuantityNum(newArray);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях 
//(Если я верно поняла это не индекс а именно позиция которую мы видим после вывода на экран(индекс у нее будет четный))

// int[] ArrayWithNumbers(int size)
// {
//     int[] newArray = new int[size];
//     {
//         for (int i = 0; i < size; i++)
//         {
//             newArray[i] = new Random().Next(1, 1000);
//         }
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Получившийся массив ->  ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SumNum(int[] array)
// {
//     int count = 0;
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 0)
//             sum = sum + array[i];
//         count++;
//     }
//     Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
// }
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] newArray = ArrayWithNumbers(size);
// ShowArray(newArray);
// SumNum(newArray);

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] ArrayWithNumbers(int size)

// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100, 1000);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.WriteLine("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void DiffMaxMin(int[] array)
// {
//     int max = array[0];
//     int min = array[0];
//     int count = 0;
//     int diff = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         count++;
//         if (array[i] < min) min = array[i];
//         count++;
//         diff = max - min;
//     }
//     Console.WriteLine($"Максимальный элемент -> {max},\nМинимальный элемент -> {min} \nРазница между элементами max и min = {diff}");
// }
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] newArray = ArrayWithNumbers(size);
// ShowArray(newArray);
// DiffMaxMin(newArray);




