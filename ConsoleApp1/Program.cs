Console.WriteLine("Задача 41");
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



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