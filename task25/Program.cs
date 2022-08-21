int Pow (int num, int numX)
{
    int result = num;
    for (int i = 1; i < numX; i++)
    {
        result = result * num;
    }
    return result;
}


Console.Write("Напишите число ");
int number = int.Parse(Console.ReadLine());
Console.Write("Напишите число в какую степень возводим ");
int numberX = int.Parse(Console.ReadLine());

int result =  Pow(number, numberX);
Console.Write(result);