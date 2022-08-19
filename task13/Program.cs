Console.Write("Напишите число ");
int number = int.Parse(Console.ReadLine());
if(number < 100){
    Console.WriteLine("Третьей цифры нет");
}
else{
    int num1 = number / 100;
    int result = num1 % 10;
    Console.WriteLine(result);
}