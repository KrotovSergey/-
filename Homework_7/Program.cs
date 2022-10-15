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
            System.Console.Write("[");
            for (int j = 0; j < cols; j++)
            {
                System.Console.Write($"{tempArray[i, j]} ");
            }
            System.Console.WriteLine("]");
        }
    }
}
void Zadacha2()
{

}

void Zadacha3()
{

}
