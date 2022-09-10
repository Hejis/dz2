// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
if (anyNumber < 1000)
 {
    int result = (anyNumber/100)%10;
    if (result != 0 ){
    Console.WriteLine("третья цифра -> " + result);
    }
    else {
    Console.WriteLine("-> третьей цифры нет");
    }
 }
else {
    Console.WriteLine("Ваше число не трехзначное");
}

