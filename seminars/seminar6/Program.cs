//перевернуть массив, последний элемент на мете 1


// int [] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     Console.Write($"Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--)
//     {
//     int temp = array[i];
//     array[i] = array[j];
//     array[j] = temp;
//     }
//     return array;
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);
// ShowArray(ReverseArray(myArray));

//принимает на вход 3 числа и проверяет может ли существовать треугольник со сторонами такой длинны

// bool CheckTri (int a, int b, int c)
// {
//     if (a+b>c && b+c>a && a+c>b)
//     return true;
//     return false;
// }

// int CheckNum ()
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x<=0) return CheckNum();
//     else return x;
// }
// Console.WriteLine("Введите сторону А");
// int a = CheckNum();
// Console.WriteLine("Введите сторону B");
// int b = CheckNum();
// Console.WriteLine("Введите сторону C");
// int c = CheckNum();

// Console.WriteLine(CheckTri(a, b, c));

// без рекурсии вывести первые N чисел Фибоначи, первые 2 числа обозначить a и b

// int [] Fib (int a, int b, int n)
// {
//     int [] newArray = new int [n];
//     newArray[0] = a;
//     newArray[1] = b;
//     for (int i = 2; i < n; i++)
//     {
//         newArray[i] = newArray[i-1] + newArray[i-2];
//     }
//     return newArray;
// } 
// void Show (int [] array)
// {
//     Console.WriteLine($"Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());
// Show(Fib(a, b, n));

// преобразовать десятичное число в двоичное

// string Transform(int num)
// {
//     string result = String.Empty;
//     int bin;
//     while (num > 0)
//     {
//         bin = num % 2;
//         result = bin + result;
//         num = num / 2;
//     }
//     return result;
// }
// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Transform(a));