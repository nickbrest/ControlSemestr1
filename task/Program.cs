// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

string[] FilterArray(string[] origArray, int qtySimbols)
{
    string[] newArray = new string[0];
    for (int i = 0, j = 0; i < origArray.Length; i++)
        if (origArray[i].Length <= qtySimbols)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[j] = origArray[i];
            j++;
        }
    return newArray;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
        Console.WriteLine($"В имеющемся массиве строки с заданной длиной отсутствуют.");
    else
        for (int i = 0; i < array.Length; i++)
            Console.Write($"{array[i]} ");
}

string[] origArray = { "hello", "привет", "сон", "23", "дятел", "pc", "felis silvestris", "кот" };
string[] filteredArray = FilterArray(origArray, 3);
PrintArray(filteredArray);