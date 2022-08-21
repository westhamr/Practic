int Sum (int num)
{
    int numSum = 0;
    while (num > 0)
    {
        numSum = numSum + (num % 10);
        num = num / 10;
    }
    return numSum;
}

Console.Write("Напишите число ");
int number = int.Parse(Console.ReadLine());

int result = Sum(number);
Console.Write(result);