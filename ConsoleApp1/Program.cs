Console.WriteLine("Задача 34");
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Введите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
void fillArray(int[] my_array)
{
    for (int i = 0; i < my_array.Length; i++)
    {
        my_array[i] = new Random().Next(100, 1000);
    }

}
void fillArrayDouble(double[] my_array)
{
    for (int i = 0; i < my_array.Length; i++)
    {
        my_array[i] = new Random().NextDouble() * new Random().Next(-500, 500);
    }

}
void printArray(int[] my_array)
{
    for (int i = 0; i < my_array.Length; i++)
    {
        Console.Write(my_array[i] + " ");
        
    }
Console.WriteLine();
}
void printArrayDouble(double[] my_array)
{
    for (int i = 0; i < my_array.Length; i++)
    {
        Console.Write(my_array[i] + " ");
        
    }
    Console.WriteLine();
}
void printArrayChetnie(int[] my_array)
{
    int count = 0;
    for (int i = 0; i < my_array.Length; i++)
    {
        if (my_array[i] % 2 == 0) count++;

    }
    Console.WriteLine("Четных чисел " + count);
}
fillArray(array);
printArray(array);
printArrayChetnie(array);


Console.WriteLine("Задача 36");
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
Console.WriteLine("Введите количество элементов в массиве: ");
int N2 = Convert.ToInt32(Console.ReadLine());
int[] array2 = new int[N2];
void summaElementovNaNechetnixMestax(int[] my_array)
{
    int count = 0;
    if (my_array.Length <= 3)
    {
        Console.WriteLine("Cумма элементов, стоящих на нечётных позициях " + my_array[1]);
        return;
    }
    for (int i = 1; i < my_array.Length; i = i+2)
    {
        count += my_array[i];

    }
    Console.WriteLine("Cумма элементов, стоящих на нечётных позициях " + count);
}
fillArray(array2);
printArray(array2);
summaElementovNaNechetnixMestax(array2);


Console.WriteLine("Задача 36");
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите количество элементов в массиве: ");
int N3 = Convert.ToInt32(Console.ReadLine());
double[] array3 = new Double[N3];
double max, min, raznica;

fillArrayDouble(array3);
printArrayDouble(array3);
Console.WriteLine($"{array3.Max()} {array3.Min()}");
Console.WriteLine(array3.Max() - array3.Min());

