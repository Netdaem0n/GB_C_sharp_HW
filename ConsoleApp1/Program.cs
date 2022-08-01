Console.WriteLine("Задача 47");
// //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// //Например, задан массив:
// //1 4 7 2
// //5 9 2 3
// //8 4 2 4
//
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine($"Задайте двумерный массив размером m * n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
CreateArrayDouble(array);
WriteArray(array);
WriteArraySortted(array);
Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(1, 999);
        }
    }
}

void WriteArray (double[,] array){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 3);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

void WriteArraySortted (double[,] myarray)
{
    double[] tempArray = new double[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[j] = myarray[i, j];
        }
        Array.Sort(tempArray);
        for (int k = 0; k < tempArray.Length; k++)
        {
            Console.Write(tempArray[k] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задача 56");
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
m = 4;
n = 4;
double[,] array2 = new double[m, n];

CreateArrayDouble(array2);
WriteArray(array2);
WriteArraySorttedByString(array2);


void WriteArraySorttedByString (double[,] myarray)
{
    double[] tempArray = new double[n];
    double[] sumArray = new double[n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[j] = myarray[i, j];
        }

        var sum = tempArray.Sum();
        Console.Write(sum);
        sumArray[i] = sum;
        Console.WriteLine();
    }
    double min = sumArray[0];
    int index = 0;
    for (int i = 1; i < sumArray.Length; i++)
        if (min > sumArray[i])
        {
 
            min = sumArray[i];
 
            index = i;
        }
    Console.WriteLine("Индекс минимального элемента массива (Строки)  " + index);
}

Console.WriteLine("Задача 58");
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] arrayInt1 = new int[m, n];
int[,] arrayInt2 = new int[m, n];

CreateArrayInt(arrayInt1);
CreateArrayInt(arrayInt2);
WriteArrayInt(arrayInt1);
WriteArrayInt(arrayInt2);
WriteArrayMultiply(arrayInt1, arrayInt2);

void CreateArrayInt(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 99);
        }
    }
}

void WriteArrayInt (int[,] array){
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void WriteArrayMultiply (int[,] myarray1, int[,] myarray2)
{
    int[,] tempArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[i, j] = myarray1[i, j] * myarray2[i, j];
        }
    }
    WriteArrayInt(tempArray);
}

Console.WriteLine("Задача 60");
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//
//массив размером 2 x 2 x 1
//
//12(0,0,0) 22(0,0,1)
//
//45(1,0,0) 53(1,0,1)
m = 3;
n = 3;
int k = 3;
int[,,] arrayInt3 = new int[m, n, k];

CreateArrayInt3(arrayInt3);
WriteArrayInt3(arrayInt3);


void CreateArrayInt3 (int[,,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
              array[i, j, l] = new Random().Next(1, 99);  
            }
        }
    }
}

void WriteArrayInt3 (int[,,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                Console.Write($"{array[i, j, l]} [{i} ,{j}, {l}]  ");
            };
            Console.WriteLine();
        }
    } }

Console.WriteLine("Задача 62");
// Задача 62. Заполните спирально массив 4 на 4
// Например, на выходе получается вот такой массив:
//
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArrayMatrix(sqareMatrix);

void WriteArrayMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
                Console.Write($" {array[i,j]} ");

            else Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}