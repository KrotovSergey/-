Console.WriteLine("Какую задачу проверить?: 47/50/52 ");

int zadacha = int.Parse(Console.ReadLine());

if (zadacha == 47)
{
    Zadacha1();
}
else if (zadacha == 50)
{
    Zadacha2();
}
else if (zadacha == 52)
{
    Zadacha3();
}

void Zadacha1()

{
    Console.Clear();

    char[] separators = { ' ', ',', ';' };

    Console.Write("Введите количество строк: ");

    int rowCount = InputNumbers();

    Console.Write("Введите количество столбцов: ");

    int colCount = InputNumbers();

    int[,] intArray = new int[rowCount, colCount];

    double[,] doubleArray = new double[rowCount, colCount];
    FillRandomArray(doubleArray, 0.0, 99.9);
    PrintMatrix(doubleArray);
    int InputNumbers()
    {
        int number = 0;
        bool isConverted = false;
        while (isConverted != true)
        {
            string input1 = Console.ReadLine() ?? "-r";
            try
            {
                number = Convert.ToInt32(input1);
                isConverted = true;
            }
            catch (FormatException)
            {
                isConverted = false;
                Console.WriteLine("Неправильно задано число");
            }
        }
        return number;
    }


    void FillRandomArray(double[,] tempArray,
                                    double firstNum,
                                    double secondNum)
    {
        int rows = tempArray.GetLength(0);
        int cols = tempArray.GetLength(1);
        var r = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempArray[i, j] = Math.Round(firstNum + r.NextDouble() * (secondNum - firstNum), 2);
            }
        }
    }
    void PrintMatrix(double[,] tempArray)
    {
        int rows = tempArray.GetLength(0);
        int cols = tempArray.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            Console.Write("[");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{tempArray[i, j]} ");
            }
            Console.WriteLine("]");
        }
    }
}

void Zadacha2()
{
    Console.Clear();

    char[] separators = { ' ', ',', ';' };

    Console.Write("Введите количество строк: ");

    int rowCount = InputNumbers();

    Console.Write("Введите количество столбцов: ");

    int colCount = InputNumbers();

    int[,] intArray = new int[rowCount, colCount];

    FillRandomArray(intArray, 1, 99);

    PrintMatrix(intArray);

    int InputNumbers()
    {
        int number = 0;
        bool isConverted = false;
        while (isConverted != true)
        {
            string input1 = Console.ReadLine() ?? "-r";
            try
            {
                number = Convert.ToInt32(input1);
                isConverted = true;
            }
            catch (FormatException)
            {
                isConverted = false;
                Console.WriteLine("Неправильно задано число");
            }
        }
        return number;
    }

    PrintMatrix(intArray);

    int[] elementPosition = new int[2];

    while (true)
    {
        Console.WriteLine("Введите позицию элемента (2 числа): ");

        elementPosition = Console.ReadLine()!.Split(separators).Select(int.Parse).ToArray();

        if (elementPosition.Length >= 2) break;

        Console.WriteLine("Нужно ввести 2 цифры");
    }
    if (elementPosition[0] >= rowCount || elementPosition[1] >= colCount)
    {
        Console.WriteLine("Номер позиции выходит за границы массива.");
        
    }
    Console.WriteLine($"Элемент на позиции [{elementPosition[0]},{elementPosition[1]}] = {intArray.GetValue(elementPosition)}");

    void FillRandomArray(int[,] tempArray, int firstNum, int secondNum)
    {
        int rows = tempArray.GetLength(0);
        int cols = tempArray.GetLength(1);
        var r = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempArray[i, j] = r.Next(firstNum, secondNum);
            }
        }
        // return tempArray;
    }

    void PrintMatrix(int[,] tempArray)
    {
        int rows = tempArray.GetLength(0);
        int cols = tempArray.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            Console.Write("[");
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,3}", tempArray[i, j]);
            }
            Console.WriteLine("]");
        }
    }
}

void Zadacha3()
{

}
