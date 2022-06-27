Console.WriteLine("Задача 10");
int temp;
h10:
Console.Write("Введите трехзначное число ");
string a = Console.ReadLine();


if (a.Length == 3 & int.TryParse(a, out temp))
{
    Console.Write($"Вы ввели {a}, Вторая цифра ");
    Console.Write(a[1] + "\n");
    Console.WriteLine("------------------");
}
else
{
    Console.WriteLine($"Введите трехзначное число, Вы ввели {a}");
    goto h10;}


Console.WriteLine("Задача 13");
h13:
Console.Write("Введите число ");
a = Console.ReadLine();
if (int.TryParse(a, out temp))
{
    if (a.Length >= 3)
    {
        Console.Write($"Вы ввели {a}, третья цифра ");
        Console.Write(a[2] + "\n");
        Console.WriteLine("------------------");
    }
    else
    {
        Console.WriteLine($"Вы ввели {a}, третьей цифры нет");
    }
}

else
{
    Console.WriteLine($"Введите число, Вы ввели {a}");
    goto h13;}


Console.WriteLine("Задача 15");
h15:
Console.Write("Введите день недели (число) ");
a = Console.ReadLine();
if (int.TryParse(a, out temp))
{
    temp = Convert.ToInt32(a);
    if (temp == 6 | temp == 7)
    {
        Console.WriteLine($"Ура, Выходной!!!!");
        Console.WriteLine("------------------");
    }
    else
    {
        Console.WriteLine($"Работаем, к сожалению {a} день недели не выходной");
    }
}

else
{
    Console.WriteLine($"Введите число, Вы ввели {a}");
    goto h15;}

