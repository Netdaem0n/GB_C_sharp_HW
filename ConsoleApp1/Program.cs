Console.WriteLine("Итоги блока");


string answer = "";

while ((answer != "1") && (answer != "2")) {
Console.Write("Использовать массив строк заданный в переменной (1) или задасть его через пробел (2) (введите 1 или 2) :");
answer = Console.ReadLine();
}
Console.WriteLine("Вы выбрали " + answer);
