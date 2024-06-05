/* Задача: Написать программу, которая из имеющегося 
массива строк формирует новый массив из строк, длина 
которых меньше, либо равна 3 символам. Первоначальный 
массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно 
массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


string[] FilterShortStrings(string[] strings)
{

    int shortStringsCount = CountShortStrings(strings);
    string[] result = new string[shortStringsCount];
    int index = 0;

    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            result[index++] = strings[i];
        }
    }
    return result;

}

static int CountShortStrings(string[] strings)
{
    int count = 0;

    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}



Console.WriteLine("Input few short strings separated by spaces: ");
string input = Console.ReadLine();
string[] strings = input.Split(' ');

string[] result = FilterShortStrings(strings);

Console.WriteLine("Filtered strings: ");
Console.WriteLine(string.Join(", ", result));
