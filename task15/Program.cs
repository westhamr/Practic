Console.Write("Напишите номер дня недели ");
int number = int.Parse(Console.ReadLine());
if(number > 7){
    Console.Write("Нет столько дней в неделе ");
    return;
}
if(number == 7 || number == 6 ){
    Console.WriteLine("Выходной");
}
else{
    Console.WriteLine("Будний день");
}
