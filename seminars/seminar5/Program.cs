

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
//     //Console.WriteLine();
// }

// // //замены эл массива положительные на отриц и наоборот

// int [] InvertArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// массив из 12 элем, заполнен случайными числами из промежутка от -9 до 9, найти сумму - и + элементов массива

// void FindMinMaxSum(int[] array)
// {
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPositive = sumPositive + array[i];
//         else sumNegative += array[i];
//     }
//     Console.WriteLine($"Сумма положительных чисел в массиве равна -> {sumPositive} \n Сумма отрицательных чисел в массиве равна -> {sumNegative} ");
// }


// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(a, min, max);
// ShowArray(myArray);
// //ShowArray(InvertArray(myArray));
// FindMinMaxSum(myArray);


//массив запрашивает числа у пользователя и отвечает присутствует ли заданное число

int [] New (int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент{i} ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray(int[] array)
{
    Console.Write("Получившийся массив ->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    //Console.WriteLine();
}

bool number1(int[] array)
{
    Console.WriteLine($"Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = New(a);
ShowArray(myArray);
Console.Write(number1(myArray));

// в массиве 123 числа,  найти кол во элементов массива значение которых лежит в отрезке от 10 до 99

// int [] New (int size)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//        newArray[i]  = new Random().Next(1, 1000);
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

// void FindNumber (int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ( array[i] >= 10 && array[i] <=99) count++;
//     }
//     Console.WriteLine(count);
// }
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] newArray = New (size);
// ShowArray(newArray);
// FindNumber(newArray);





// string[] New(int size)
// {
    
//     string[] newArray = new string[size];    
//     for (int i = 0; i < size; i++)
//     {   
        
//         Console.WriteLine($"Введите элемент{i + 1} ");
//         newArray[i] = Console.ReadLine();
//     }
//     return newArray;
// }
// void ShowArray(string[] array)
// {
//     Console.Write("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void N(string[] array)
// {   
//     int count = 0;
//     Console.Write("Получившийся новый массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {   
        
//         if (array[i].Length < 4)
//         {
//             Console.Write(array[i] + " ");
//             count++;            
//         }
        
//     }

// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// string[] newArray = New(size);
// ShowArray(newArray);
// N(newArray);

//Найдите разницу между максимальным и минимальным элементов массива

// int [] N1 (int size)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(100,1000);
//     }
//     return newArray;
// }
// void N2 (int [] array)
// {
//     Console.Write("Новый массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// void N3 (int [] array)
// {
//     int max = array[0];
//     int min = array[0];
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//         if (array[i] > max) max = array[i];
               
//     }
//      int res = max - min;
//     Console.WriteLine($"Максимальный элемент -> {max}, минимальный элемент -> {min}, разница между ними -> {res}");
// }
// Console.WriteLine("Введите размер массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] myArray = N1(n);
// N2(myArray);
// N3(myArray);