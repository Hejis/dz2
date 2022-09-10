//  Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает
// вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число.");

int a = Convert.ToInt32(Console.ReadLine()); 
int number2 = (a % 100) / 10;
Console.WriteLine($"Вторая цифра числа {number2} ");