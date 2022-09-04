void PrintArray(int[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             Console.Write($"{matr[i, j]} ");
         }
         Console.WriteLine();
     }
 }
 void FillArray(int[,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             matr[i,j] = new Random().Next(1,10);
         }
     }
}
double arithmetic(int[,] arr, int colum)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i,colum];
    }
    sum = sum/arr.GetLength(0);
    return sum;
}
void PrintMiddle(int[,] arr)
{
    for (int k = 0; k < arr.GetLength(1); k++)
{
    double MiddleSum = arithmetic(arr, k);
    Console.Write("{0,6:F2}", MiddleSum + " ");
}
}
Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,colums];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintMiddle(array);
