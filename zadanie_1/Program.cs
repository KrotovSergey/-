// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7

Console.Clear();

Console.Write("введи пераое число: ");

int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");

int number2 = int.Parse(Console.ReadLine());

if(number1 < number2)
{
    Console.WriteLine($"наибольшее число {number2}");
}
else if(number1 > number2)
{
    Console.WriteLine($"наибольшее число {number1}");
};
