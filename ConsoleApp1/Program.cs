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

Console.WriteLine("Задача 21");
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты двух точек в формате, каждое с новой строки");
double[] abc = new double[3];
double[] def = new double[3];
abc[0] = Convert.ToDouble(Console.ReadLine());
abc[1] = Convert.ToDouble(Console.ReadLine());
abc[2] = Convert.ToDouble(Console.ReadLine());
def[0] = Convert.ToDouble(Console.ReadLine());
def[1] = Convert.ToDouble(Console.ReadLine());
def[2] = Convert.ToDouble(Console.ReadLine());
double distanse;
distanse = Math.Sqrt(
    Math.Pow(def[0] - abc[0], 2) +
    Math.Pow(def[1] - abc[1], 2) +
    Math.Pow(def[2] - abc[2], 2)
);
Console.WriteLine(distanse);

Console.WriteLine("Задача 23");
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write(Math.Pow(i, N) + " ");
}
