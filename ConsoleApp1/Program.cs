Console.WriteLine("Итоги блока");


string answer = "";

while ((answer != "1") && (answer != "2")) {
Console.Write("Использовать массив строк заданный в переменной (1) или задасть его через пробел (2) (введите 1 или 2) :");
answer = Console.ReadLine();
}
Console.WriteLine("Вы выбрали " + answer);

string goodToGo = "";
MyChoise(answer);
var goodToGoArray = goodToGo.Split(" ");
PrintArray(goodToGoArray);

void MyChoise(string choise)
{
    if (choise == "1")
    {
        string[] array = new string[6]{"value1","value2","value3", "11", "!", "!!!!!"};
        CheckSize(array);
    }
    if (choise == "2")
    {
        Console.Write("задайте его через пробел: ");
        string a = Console.ReadLine();
        var array = a.Split(" ");
        CheckSize(array);
    }
}

void CheckSize(string[] myarray)
{
    string emptyString = "";
    for (int i = 0; i < myarray.Length; i++)
    {
        if (myarray[i].Length <= 3) emptyString += myarray[i] + " ";
    }
    goodToGo = emptyString;
}

void PrintArray (string[] myarray)
{
    for (int i = 0; i < myarray.Length; i++)
    {
        Console.Write(myarray[i] + " ");
    }
}

