Console.Write("Напишите первое число ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Меньшее = "+ number2 + ", Большее = " + number1);   
}
if (number2 > number1)
{
    Console.Write("Меньшее = "+ number1 + ", Большее = " + number2);   
}
if (number1 == number2)
{
     Console.Write("Числа равны"); 
}