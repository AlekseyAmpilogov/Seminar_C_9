Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n != 0) && (m == 0))
    {
        return Akkerman(n - 1, 1);
    }
    else
    {
        return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}

Console.WriteLine(Akkerman(n, m));
