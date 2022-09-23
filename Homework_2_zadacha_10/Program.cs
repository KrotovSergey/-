
Console.Clear();

Console.Write("Введите число: ");

int a = int.Parse(Console.ReadLine());

int b = (a - (a/100)*100) / 10;

Console.WriteLine(b);