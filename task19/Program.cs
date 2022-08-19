Console.Write("Напишите пятизначное число ");
int number = int.Parse(Console.ReadLine());
int num15 = (number / 10000) - (number % 10);
//int b1 = (number % 100) / 10;
//int b2 = (number / 1000) % 10;
int num24 = ((number / 1000) % 10)-((number / 1000) % 10);
if(num15 + num24 == 0){
    Console.WriteLine("Число является палиндромом ");
}
else{
    Console.WriteLine("Число НЕ является палиндромом ");
}