int strsCount = 4;
int columnsCount = 4;
Random rnd = new Random();
int[,] array = new int[strsCount, columnsCount];

void FillArray(int[,] array)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= strsCount * columnsCount)
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < columnsCount - 1)
            ++j; // или j+1
        else if (i < j && i + j >= strsCount - 1)
            ++i; // или i+1
        else if (i >= j && i + j > columnsCount - 1)
            --j; // или j-1
        else
            --i; // или i-1
        ++value; // или num+1
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t " + array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("\nЗаполненный спирально массив: ");
FillArray(array);
PrintArray(array);
