Console.WriteLine("Задача 2");
int a = Convert.ToInt32(Console.ReadLine()),
    b = Convert.ToInt32(Console.ReadLine());
Console.Write("Большее число - ");
if (a > b) { Console.WriteLine(a); }
else { Console.WriteLine(b);}

Console.WriteLine("Задача 4");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine()),
    max;
Console.Write("Большее число из трех - ");
if (a > b)
{
    max = a;
}
else
{
    max = b;}
if (c > max) { max = c; }

Console.WriteLine(max);

Console.WriteLine("Задача 6");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Четное ли число ? Вот и ответ - ");
if (a % 2 == 0) { Console.WriteLine("Да"); }
else { Console.WriteLine("Нет");}

Console.WriteLine("Задача 8");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все четные числа в диапазоне от 1 до " + a);
for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0) {Console.WriteLine(i);}
}
