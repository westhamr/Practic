Console.Write("Напишите трехзначное число ");
int number = int.Parse(Console.ReadLine());
int num23 = number % 100;
int result = num23 / 10;
Console.WriteLine(result);