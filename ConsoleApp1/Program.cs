Console.WriteLine("Задача 64");
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 5, 6, 7, 8""
Console.Write("Введите M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N ");
int n = Convert.ToInt32(Console.ReadLine());

WriteNumbers(m, n);

void WriteNumbers(int m, int n)
{
    for (int i = m; i <= n; i++)
    {
        if (i > 0) Console.Write(i + " ");
    }
}

Console.WriteLine("Задача 66");
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

MN(m, n);
WriteNumbersSum(m, n);

void MN(int m, int n)
{
    Console.Write("Введите M ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N ");
    n = Convert.ToInt32(Console.ReadLine()); 
}

void WriteNumbersSum (int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        if (i > 0) sum += i;
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} : {sum}");
}

Console.WriteLine("Задача 68");
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

MN(m, n);

int functionAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

