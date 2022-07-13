Console.WriteLine("Задача 41");
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//
//print([int(x) > 0 for x in input().split(",")].count(True))
//
//print(len([x for x in input().split(",") if int(x) > 0]))



Console.Write("Введите числа через разделитель запрятую (пример: 3, 4, -7)");

string user_text = Console.ReadLine();
string[] numbers = user_text.Split(',');

void wtf(string[] numbers)
{
    int temp_ok = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        int temp = Convert.ToInt32(numbers[i]);
        if (temp > 0) temp_ok++;
    }
    Console.WriteLine("Чисел больше 0 : " + temp_ok);
}

wtf(numbers);

Console.WriteLine("Задача 43");
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите b1, k1, b2 и k2");
int b1 = Convert.ToInt32(Console.ReadLine()),
    k1 = Convert.ToInt32(Console.ReadLine()),
    b2 = Convert.ToInt32(Console.ReadLine()),
    k2 = Convert.ToInt32(Console.ReadLine());
int x, y;
if (k1 == k2) Console.WriteLine("Эти прямые параллельны");
else
{
    x = (b1 - b2) / (k2 - k1);
    y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.WriteLine($"Точка пересечения P имеет координаты ({x},{y}) ");
}




