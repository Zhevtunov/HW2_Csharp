// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int rez = -1;
while (number > 999)
{
  number = number / 10;
  rez = number % 10;
}

if (number / 100 < 1)
{
  Console.WriteLine("Третьей цифры нет");
}
else
{
  rez = number % 10;
  Console.Write($"Третья цифра ввашего числа: ");
  Console.WriteLine(rez);
}