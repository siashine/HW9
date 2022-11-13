// РЕКУРСИЯ Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все чётные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.Clear();
Console.WriteLine("Введите число : ");
int num = int.Parse(Console.ReadLine());
Recursia(num);

void Recursia(int num)
{
  if (num % 2 != 0) num -= 1;
  if (num >= 2)
  {
    Console.Write($" {num} "); Recursia(num - 2);
  }
}
Console.WriteLine();