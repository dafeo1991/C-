﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] Numbers(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Введите элемент {i + 1}");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
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
// void Sum(int[] array)
// {
//     int num = 0;
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) num = num + 1;
//         count++;
//     }
//     Console.WriteLine($"Количество чисел > 0 = {num}");
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] myArray = Numbers(a);
// ShowArray(myArray);
// Sum(myArray);

//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// способ1

// double Coordinates(double k1, double b1, double k2, double b2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     return x;
//     double y = k1 * (b2 - b1) / (k1 - k2) + b1;
//     return y;
// }

// Console.WriteLine("Введите координаты k1, b1, k2, b2");
// double k1 = Convert.ToDouble(Console.ReadLine());
// double b1 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());
// double b2 = Convert.ToDouble(Console.ReadLine());
// double x = Coordinates(k1, b1, k2, b2);
// double y = Coordinates(k1, b1, k2, b2);
// Console.WriteLine($"Точка пересечения двух прямых -> x {x}, y {y}");

//Способ 2

// void Coordinates(double k1, double b1, double k2, double b2)
// {

//     double x = (b2 - b1) / (k1 - k2);
//     double y = k1 * (b2 - b1) / (k1 - k2) + b1;
//     Console.WriteLine($"Точка пересечения двух прямых -> x {x}, y {y}");

// }


// Console.WriteLine("Введите координаты k1, b1, k2, b2");
// double k1 = Convert.ToDouble(Console.ReadLine());
// double b1 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());
// double b2 = Convert.ToDouble(Console.ReadLine());
// Coordinates(k1, b1, k2, b2);

