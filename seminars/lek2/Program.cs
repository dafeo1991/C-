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
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
/*Method21("Text", 4);*/
//Method21(count:4, msg:"new text");

//3. Что то возвращают, ничего не принимают

