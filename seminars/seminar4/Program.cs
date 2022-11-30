// Принимает число А и выдает сумму чисел от 1 до А
// int Findsum (int a)
// {
//     int sum = 0;
//     {
//         for (int i = 1; i <= a; i++)
//         {
//             sum = sum + i;
//         }
//         return sum;
//     }
// }

// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = Findsum(number);
// Console.WriteLine(result);

//принимает число и выдает количество цифр в числе (делим на 10 пока остаток не будет < 0  и считаем кол во раз)

// int CountDigit (int num)
// {
//     int count = 0;
//     while (num>0)
//     {
//         num = num / 10;
//         count ++;
//     }
//     return count;
// }
// Console.WriteLine("Iptum number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountDigit(number));

// Принимает число N выдает произведение чисел от 1 до  N (факториал)

// int Fak (int num)
// {
//     int result = 1;
//     for (int i = 1; i <= num; i++)
//     {
//          result = i * result;
//     }
//     return result;
// }
// Console.WriteLine("Iptum number");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Fak(number));

// выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке

// void FilArray (int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,2);
//         Console.Write($"{array[i]}");
//     }
// }
// FilArray(8);

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
//     Console.Write("Получившийся массив ->");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);