Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. ");
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. ");
Console.WriteLine("Какую задачу проверить?: 54/56/58 ");

int zadacha = int.Parse(Console.ReadLine());
if (zadacha == 54)
{
    Zadacha1();
}
else if (zadacha == 56)
{
    Zadacha2();
}
else if (zadacha == 58)
{
    Zadacha3();
}

void Zadacha1()
{
    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] filledArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
    // разделение двумерного массива на одномернве и сортиовка каждого с выводом в виде двумерного массива
    void OneArray(int[,] UnsortArray, int rows, int columns)
    {
        int[] tempArray = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            tempArray[j] = UnsortArray[rows, j];
            //Console.Write(" "+tempArray[j]);
        }
        Array.Sort(tempArray, (x, y) => y.CompareTo(x));
        for (int i = 0; i < tempArray.Length; i++)
        {
            Console.Write(" " + tempArray[i]);
        }
        Console.WriteLine();
    }



    while (true)
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Введите количество строк двумерного массива");
            int rowCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива");
            int columnCount = int.Parse(Console.ReadLine());



            int[,] array = FillArray(rowCount, columnCount, 1, 10);
            PrintArray(array);
            Console.WriteLine();

            for (int i = 0; i < rowCount; i++)
                OneArray(array, i, columnCount);
        }
        catch { Console.WriteLine("Ошибка ввода"); }

        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
    }

}

void Zadacha2()
{
    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] filledArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }
    // печать цветной строки с наименьшей суммой
    void PrintArrayColor(int[,] inputArray, int posofrow)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                if (i == posofrow)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" " + inputArray[i, j]);
                }
                else
                {
                    Console.ResetColor();
                    Console.Write(" " + inputArray[i, j]);
                }
            }
            Console.WriteLine();
        }

    }
    // нахождение суммы строки массива
    int SumOfRow(int[,] array, int rows, int columns)
    {
        int sum = 0;
        for (int i = 0; i < columns; i++)
        {
            sum += array[rows, i];
        }
        return sum;
    }

    while (true)
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Введите количество строк двумерного массива");
            int rowCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива");
            int columnCount = int.Parse(Console.ReadLine());



            int[,] array = FillArray(rowCount, columnCount, 1, 10);
            int[] massOfSum = new int[rowCount];
            PrintArray(array);
            for (int i = 0; i < rowCount; i++)
            {
                Console.WriteLine($"{i + 1}-я строка сумма = {SumOfRow(array, i, columnCount)}");
                massOfSum[i] = SumOfRow(array, i, columnCount);
            }
            int maxPos = 0;
            int maxEl = massOfSum[0];
            for (int i = 0; i < massOfSum.Length; i++)
            {
                if (maxEl >= massOfSum[i])
                {
                    maxEl = massOfSum[i];
                    maxPos = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"{maxPos + 1}-я строка ");

            PrintArrayColor(array, maxPos);

        }

        catch { Console.WriteLine("Ошибка ввода"); }

        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
    }
}

void Zadacha3()
{
    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] filledArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                filledArray[i, j] = new Random().Next(min, max + 1);
            }
        }
        return filledArray;
    }

    void PrintArray(int[,] inputArray)
    {
        for (int i = 0; i < inputArray.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                Console.Write(" " + inputArray[i, j]);
            }
            Console.WriteLine();
        }
    }

    int[,] Multiplication(int[,] a, int[,] b)
    {
        int[,] MultArray = new int[a.GetLength(0), b.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    MultArray[i, j] += a[i, k] * b[k, j];
                }
            }
        }
        return MultArray;
    }









    while (true)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        // PrintArray(FillArray(100,100,0,1));
        Console.Clear();
        Console.ResetColor();


        try
        {
            Console.WriteLine("Введите количество строк матрицы 1");
            int rowCount1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы 1");
            int columnCount1 = int.Parse(Console.ReadLine());
            int[,] array1 = FillArray(rowCount1, columnCount1, 1, 10);
            PrintArray(array1);

            Console.WriteLine("Введите количество строк матрицы 2");
            int rowCount2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы 2");
            int columnCount2 = int.Parse(Console.ReadLine());
            int[,] array2 = FillArray(rowCount2, columnCount2, 1, 10);
            PrintArray(array2);
            if (columnCount1 == rowCount2)
            {

                Console.WriteLine("Перемножаю...");
                PrintArray(Multiplication(array1, array2));


            }
            else Console.WriteLine("Произведение не возможно");

        }

        catch { Console.WriteLine("Ошибка ввода"); }

        Console.Write("<Enter  продолжение > <Пробел> для выхода ... ");
        if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            break;
    }
}
