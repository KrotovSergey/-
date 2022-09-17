// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7

Console.Clear();

Console.Write("Введите число 1: ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");

int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите число 3: ");

int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > number1)
   {
    max = number2;
   }
if (number3 > max)
{
    max = number3;
};

Console.WriteLine($"результат {max}");