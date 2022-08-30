double[] array = new double[5];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 100);
}

for (int j = 0; j < length; j++)
{
    Console.Write(array[j] + " ");
}
int findMax (double[] arr)
{
    int len = arr.Length;
    int index = 0;
    int mmax = 0;
    for (int t = 1; t < len; t++)
    {
        if(arr[t] > arr[mmax])
        {
            mmax = t;
        }
    }
    return mmax;
}
int findMin (double[] arr)

{
    int len = arr.Length;
    int index = 0;
    int mmin = 0;
    for (int t = 1; t < len; t++)
    {
        if(arr[t] < arr[mmin])
        {
            mmin = t;
        }
    }
    return mmin;
}
int max = findMax(array);
int min = findMin(array);
double result = array[max] - array[min];
Console.Write("Разница " + result);