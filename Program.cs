void PrintArray (string[] Print) // Распечатываем массив
{
    for (int i = 0; i < Print.Length; i++)
    {
        Console.Write($" {Print[i]} ");
    }
}

int ThreeArray (string[] Three) // Cчитаем кол-во элементов в массиве, которые <= 3
{
    int count = 0;
    for (int i = 0; i < Three.Length; i++)
    {
        if (Three[i].Length <= 3);
        count++;
    }
    return count;
}

void FillArray(string[] NewArray, string[] TransferArray) //Переносим нужные элементы в другой массив
{
    for (int i = 0, j = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i].Length <= 3 )
        {
            TransferArray[j] = NewArray[i];
            j++;
        }
    }
}

string[] Words = {"Hello", "2", "world", ":-)"};
Console.WriteLine(" ");
string[] WordsLong = new string [ThreeArray(Words)];
FillArray(Words, WordsLong);
Console.Write("Заданный массив -> ");
PrintArray(Words);
Console.WriteLine();
Console.Write("Сформированный массив ->");
PrintArray(WordsLong);