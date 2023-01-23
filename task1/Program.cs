// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int result = (number / 10) % 10;
Console.Write("Вторая цифра введенного числа: ");
Console.Write(result);