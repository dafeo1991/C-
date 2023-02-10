// Группы методов 4 шт
// 1. Ничего не принимает и не возвращает
/*void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();*/

// 2. Что то принимает, ничего не возвращает
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text sms");*/

//2.1 несколько раз написать что то, можно присвоить значение аргументу
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
/*Method21("Text", 4);*/
//Method21(count:4, msg:"new text");

//3. Что то возвращают, ничего не принимают
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//4. что то принимают и что то возвращают

string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf" + " ");
Console.WriteLine(res);

// 5. Цикл со счетчиком
// string Method4 (int count, string text)
// {

//     string result = String.Empty;
//     for(int i = 0; i < count; i++)

//     {
//         result = result + text;
//     }

//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

//6. Цикл в цикле
// for (int i = 2; i<=10; i++) 
// {
//     for (int j = 2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Задача 1
// Все пробелы заменить черточками, маленькие к и с на большие К и С;
// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";  
// Обратиться к конкретному символу string s = "qwerty"
// s [3] = r                                    012345

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}"; 
//     } 
//     return result;
// } 
// string newText = Replace(text, ' ', '|' );
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К' );
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'с', 'С' );
// Console.WriteLine(newText);

// Задача 2, отсортировать цифры от меньшей к большей
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// //вывод массива на экран
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// //замена цифр местами
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }

//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);
