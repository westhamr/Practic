Console.Write("Напишите число ");
int number = int.Parse(Console.ReadLine());

bool check; 

if (number % 2 == 0)
{
    check = true;
}
else
{
    check = false;
}
Console.WriteLine(check ? "Число четное" : "Число нечетное");
