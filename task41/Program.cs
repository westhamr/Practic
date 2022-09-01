int CountNum(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите число {i + 1} ");
        int num = int.Parse(Console.ReadLine());
        if(num > 0) count++;
    }
    return count;
}

Console.Write($"Введите количество чисел ");
int col = int.Parse(Console.ReadLine());
int c = CountNum(col);
Console.Write($"Колличество положительных чисел = {+ c} ");