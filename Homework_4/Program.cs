Console.Clear();

Console.WriteLine("Какую задачу проверить?: 25/27/29 ");

int zadacha = int.Parse(Console.ReadLine());

if (zadacha == 25)
{
    Zadacha1();
}
else if (zadacha == 27)
{
    Zadacha2();
}
else if (zadacha == 29)
{
    Zadacha3();
}


void Zadacha1()
{
   Console.WriteLine("Введите число: ");

    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число: ");

    int b = int.Parse(Console.ReadLine());

    Console.WriteLine($"число {a} в степени {b} = {Math.Pow(a, b)}");

}

void Zadacha2()
{
    Console.Clear();
    Console.WriteLine("Введите xa: ");
    int xa = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите ya: ");
    int ya = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите za: ");
    int za = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите xb: ");
    int xb = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите yb: ");
    int yb = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите zb: ");
    int zb = int.Parse(Console.ReadLine());

    double r = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));

    Console.WriteLine($"Расстояние равно {Math.Round(r, 3)}");

}

void Zadacha3()
{
    Console.WriteLine("Введите число: ");

    int a = int.Parse(Console.ReadLine());

    int b = 1;

    while (b < a)
    {
        Console.WriteLine(Math.Pow(b, 3));
        b++;
    }
}