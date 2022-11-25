/*Вывод случайных чисел и деление
double numberA = new Random ().Next (1000,3000);
Console.WriteLine(numberA);
double numberB = new Random ().Next (200,500);
Console.WriteLine(numberB);
Console.WriteLine (numberA / numberB);*/

/* Приветствие по разному
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
} 
else
{
    Console.Write("Привет, "); 
    Console.WriteLine(username);
}*/

/* Найти большее из чисел

Console.WriteLine("Input number a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number c");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number d");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number e");
int e = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);*/

/*Задача на рисование

Console.Clear();
int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count+=1;
}*/



/*Поиск самого большого числа
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
    }

int a1 = 5;
int b1 = 6;
int c1 = 7;
int a2 = 1;
int b2 = 2;
int c2 = 8;
int a3 = 10;
int b3 = 15;
int c3 = 25;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));
Console.WriteLine(max);*/

/*Сравнивали числа и находили большее
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = {11, 21, 31, 41, 1500, 61, 17, 18, 19};
/*array[0] = 12;
Console.WriteLine(array[4]);*/
/*int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(result)*/

/*индекс числа find
int [] array = {1, 2, 3, 88, 4, 5, 6, 7, 88 };
int n = array.Length;
int find = 88;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}*/

/*Метод заполнения массива и печать его на экран, поиск индекса определенного числа
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random ().Next(1, 10);
        index++;
    }
}

int [] array = new int[10];
FillArray(array);
array[4] = 4;
array[6] = 4; 
PrintArray(array);

void PrintArray(int[] col)
{
    int count = col.Length;
    int postion = 0;
    while (postion < count)
    {
        Console.WriteLine(col[postion]);
        postion++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);*/

