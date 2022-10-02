// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

  int Sum(int A)
  {
    int count = Convert.ToString(A).Length;
    int dig = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      dig = A - A % 10;
      result = result + (A - dig);
      A = A / 10;
    }
   return result;
  }

int sumNumbers = Sum(A);
Console.WriteLine("Сумма цифр: " + sumNumbers);

