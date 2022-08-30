int[] array = new int[5];
int length = array.Length;
int sum = 0;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 100);
}
for (int j = 0; j < length; j++)
{
    Console.Write(array[j] + " ");
    if(j % 2 != 0)
    {
        sum += array[j];
    }
}
Console.Write("Сумма на нечетных позициях: " + sum);