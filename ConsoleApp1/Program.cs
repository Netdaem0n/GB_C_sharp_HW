Console.WriteLine("Задача 19");
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//на pythone было бы еще быстрее
// [::-1]
//
Console.WriteLine("Введите число ");
string c, a = Console.ReadLine();
char[] b = a.ToCharArray();
Array.Reverse(b);
c = new string(b);
if (c == a)
{
   Console.WriteLine("Yes"); 
}
else {Console.WriteLine("No");}

