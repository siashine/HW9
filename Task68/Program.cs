// РЕКУРСИЯ Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите число 1: ");
int num = UserInput();
Console.WriteLine("Введите число 2: ");
int number = UserInput();

Console.WriteLine(Recursia(num, number));

int UserInput()
{
  int numb = int.Parse(Console.ReadLine());
  return numb;
}

int Recursia(int num, int number)
{
  if (num == 0) return number + 1;
  if (number == 0 && num > 0) return Recursia(num - 1, 1);
  else return Recursia(num - 1, Recursia(num, number - 1));
}