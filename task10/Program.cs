Console.Write("Напишите трехзначное число ");
int number = int.Parse(Console.ReadLine());
string str = number.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
Console.WriteLine(b[1]);