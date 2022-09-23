Console.Clear();
Console.Write("Введи число: ");
int number = int.Parse(Console.ReadLine());
if (number < 6) 
{
Console.WriteLine("Будний день");
}
else if (number >5 && number < 8)
{
Console.WriteLine("Этот день выходной, ура");
} 
else if (number > 7)
{
Console.WriteLine("Введите число от 1 до 7");
} 