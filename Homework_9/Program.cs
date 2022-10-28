Console.WriteLine("Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии. ");
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии. ");
Console.WriteLine("Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.");
Console.WriteLine("Какую задачу проверить?: 64/66/68 ? ");

int zadacha = int.Parse(Console.ReadLine());
if (zadacha == 64)
{
    Zadacha1();
}
else if (zadacha == 66)
{
    Zadacha2();
}
else if (zadacha == 68)
{
    Zadacha3();
}

void Zadacha1()

{
    int NumberRecursion(int n, int m)
    {
        if (n % 2 == 0)
            Console.WriteLine(n);
        if (n > m)
            return n;
        return (NumberRecursion(n + 1, m));
    }
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Введите число N");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число M");
        int M = int.Parse(Console.ReadLine());
        NumberRecursion(N, M);
        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
    }
}

void Zadacha2()
{
    int summRecurs(int n, int m, int sum)
    {
        sum += n;
        if (n == m) return sum;
        return (summRecurs(n + 1, m, sum));
    }
    while (true)
    {
        try
        {
            Console.Clear();
            int summ = 0;
            Console.WriteLine("Введите число N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число M");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine(summRecurs(N, M, summ));
        }
        catch
        {
            Console.WriteLine("Ошибка ввода");
        }

        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
    }
}

void Zadacha3()
{
    int NODRecursion(int n, int m)
    {
        int temp = m % n;
        if (temp == 0)
            return n;
        return NODRecursion(temp, n);
    }
    while (true)
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Введите число N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число M");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine(NODRecursion(N, M));
        }
        catch
        {
            Console.WriteLine("Ошибка ввода");
        }

        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
    }
}
