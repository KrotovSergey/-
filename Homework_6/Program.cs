

Console.WriteLine("Какую задачу проверить?: 41/43 ");

int zadacha = int.Parse(Console.ReadLine());

if (zadacha == 43)
{
    Zadacha1();
}
else if (zadacha == 41)
{
    Zadacha2();
}

void Zadacha1()
{
  (double k, double b)[] coords = new (double, double)[2];
            while (true)
            {
                Console.WriteLine("Введите значения (k1,b1) (k2,b2) в таком же формате: ");
                try
                {
                    coords = Console.ReadLine()!
                             .Replace("(", "")
                             .Replace(")", "")
                             .Split(" ")
                             .Select(a => a.Split(','))
                             .Select(b => (k: double.Parse(b[0]), b: double.Parse(b[1])))
                             .ToArray();
                }
                catch
                {
                    Console.WriteLine("Строка не была обработана. Заданы числа (1,2) (3,4)");
                    coords[0] = (1, 2);
                    coords[1] = (3, 4);
                }
                if (coords.GetLength(0) >= 2) break;
                Console.WriteLine("Нужно ввести 4 цифры");
            }
            if (coords[0].k == coords[1].k)
            {
                if (coords[0].k == coords[0].b)
                {
                    Console.WriteLine("Прямые совпадают");                    
                }
                else
                {
                    Console.WriteLine("Прямые параллельны");                    
                }
            }
            double x = (coords[1].b - coords[0].b) / (coords[0].k - coords[1].k);
            double y = coords[1].k * x + coords[1].b;
            Console.WriteLine($"Точка пересечения имеет координаты {Math.Round(x, 2)},{Math.Round(y, 2)}");  
}
void Zadacha2()
{
            Console.Write("Введите элементы(через пробел): ");
            char[] separators = { ' ', ',', ';' };

            int[] inputarray = Array.ConvertAll(Console.ReadLine()!.Split(separators), int.Parse);

            int[] tempArray = Array.FindAll(inputarray, b => b > 0);
            Console.WriteLine($"Вы ввели {tempArray.Length} чисел больше 0");
}
            