
Console.Clear();

Console.Write("Введите число: ");

int a = int.Parse(Console.ReadLine());

if (a>100)
{
    int b = (a % 10);
    Console.WriteLine(b);
}
else 
{
   Console.WriteLine("Число двузначное");
}
        