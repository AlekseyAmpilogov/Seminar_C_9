int strsCount = 4;
int columnsCount = 4;
Random rnd = new Random();
int[,] array = new int[strsCount, columnsCount];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10, 100);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}
void ArrangeDecreaseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int n = 0; n < array.GetLength(1)-1; n++)
            {
                if (array[i, n] < array[i, n + 1])
                {
                    int tmp;
                    tmp = array[i, n];
                    array[i, n] = array[i, n + 1];
                    array[i, n + 1] = tmp;
                }
            }
        }
    }
}

Console.WriteLine("\nСлучайный массив:");
FillArray(array);
PrintArray(array);
ArrangeDecreaseArray(array);
Console.WriteLine("\nУпорядоченный массив по убыванию:");
PrintArray(array);