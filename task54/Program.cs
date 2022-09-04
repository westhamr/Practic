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
void BubbleSort(int[,] arr, int row)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (arr[row, j] < arr[row, j + 1])
		    {
			    int t = arr[row, j + 1];
			    arr[row, j + 1] = arr[row, j];
			    arr[row, j] = t;
		    }
    
        }
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
for (int k = 0; k < array.GetLength(1); k++)
{
    BubbleSort(array, k);
}
PrintArray(array);

