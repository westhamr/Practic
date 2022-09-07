void PrintArray(int[,,] matr)
 {
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ");
            }
            Console.WriteLine();
         }
     }
 }
void FillArray(int[,,] matr)
 {
    for (int i = 0; i < matr.GetLength(0); i++)
    {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i,j,k] = GetRandomNum();
            }
        }   
    }
}
int GetRandomNum()
    {
        int[] matr = new int[90];
        Random random = new Random();
        int j = 9;
        for (int i = 0; i < matr.Length ; i++)
        {  
            matr[i] = j + 1;
            j++;
            /*int num = random.Next(10,99);
            if (matr.Contains(num))
            {
                i--;
            }
            else
            {
                matr[i] = num;
            }*/
          //  Console.WriteLine(matr[i]);
        }
        int randomIndex = random.Next(0, matr.Length);
        int number = matr[randomIndex];
        //matr.RemoveAt(randomIndex);
        var numbersList = matr.ToList();
        numbersList.RemoveAt(randomIndex);
        return number;
    }
Console.Write("Введите колличество строк: ");
int q = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int w = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество глубины: ");
int e = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[q,w,e];
PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);






/*Console.WriteLine("Введите размерность массива");
int rows =Convert.ToInt32(Console.ReadLine());
int[] array = new int[rows];
void GetRandomArr(int[] arr)
    {
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            var num = random.Next(0,10);
 
            if (arr.Contains(num))
            {
                i--;
            }
            else
            {
                arr[i] = num;
            }
        }
    }

GetRandomArr(array);

Console.WriteLine(String.Join(" ", array));*/