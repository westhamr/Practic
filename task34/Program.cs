int[] array = new int[5];
int length = array.Length;
int count = 0;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(100, 999);
}
for (int j = 0; j < length; j++)
{
    Console.Write(array[j] + " ");
    if(array[j] % 2 == 0)
    {
        count += 1;
    }
}
Console.Write("-> " + count);
