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