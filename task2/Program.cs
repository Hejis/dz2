// Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.
Random rnd = new Random();
int NumberValue= rnd.Next(100,999);
int result = (NumberValue % 10) + (NumberValue / 100) * 10;
Console.WriteLine($"Для числа {NumberValue} при удалении второго  разряда получаем {result} ");
