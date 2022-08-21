Console.Write("Напишите длинну массива ");
int N = int.Parse(Console.ReadLine());
Console.Write("Напишите начальное число ");
int a = int.Parse(Console.ReadLine());
Console.Write("Напишите конечное число ");
int b = int.Parse(Console.ReadLine());

int[] array = new int[N];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(a,b);
}
for (int j = 0; j < length; j++)
{
    Console.Write(array[j] + " ");
}