
Console.WriteLine("Задача 25");
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A и число B");
double a = Convert.ToInt32(Console.ReadLine()), 
    b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(a, b));

Console.WriteLine("Задача 27");
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число ");
string chislo = Console.ReadLine();
int summa = 0;
for (int i = 0; i < chislo.Length; i++)
{
    int chislo1 = Convert.ToInt32(Char.GetNumericValue(chislo[i]));
    summa += chislo1;
}
Console.WriteLine(summa);

Console.WriteLine("Задача 29");
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
char[] array = new char[8];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToChar(rnd.Next('a', 'a' + 27));
    Console.Write("{0} ", array[i]);
}
