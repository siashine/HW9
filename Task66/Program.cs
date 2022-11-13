// РЕКУРСИЯ Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число 1: ");
int num = UserInput();
Console.WriteLine("Введите число 2: ");
int number = UserInput();

Console.Write(Recursia(num, number));

int UserInput()
{
  int numb = int.Parse(Console.ReadLine());
  return numb;
}

int Recursia(int num, int number)
{
  if (num != number) return number + Recursia(num, number - 1);
  else return num;
}
Console.WriteLine();
