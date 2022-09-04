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
int SumRows(int[,] arr, int row)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        sum = sum + arr[row,i];
    }
    return sum;
}
int FindMin(int[,] arr, int colum)
{
    int res = SumRows(arr, 0);
    for (int k = 0; k < colum; k++)
    {
        if(res > SumRows(arr, k)) res = SumRows(arr, k);
    }
    return res;
}
Console.Write("Введите колличество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows,colums];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int result = FindMin(array, colums);
Console.WriteLine(result);