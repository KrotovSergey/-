//Code with methods
// Напишите программу, которая задаёт 2 одномерных массива из N 
//элементов которые заполняются случайными значениями в диапазоне 
//от N до M, находит среднее арифметическое элементов этих 2 массивов и далее выводит на экран результат суммы средних арифметических

Console.WriteLine("Введите размер 1го массива:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное возможное значение в первом массиве:");
int min1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное возможное значение в первом массиве:");
int max1 = int.Parse(Console.ReadLine());

int [] firstArray = FillArray(size,min1,max1); 

Console.WriteLine("Первый массив: [ " + String.Join(",", firstArray) + " ]");

Console.WriteLine("Введите размер 2го массива:");
int size2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное возможное значение во втором массиве:");
int min2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное возможное значение во втором массиве:");
int max2 = int.Parse(Console.ReadLine());

int [] secondArray = FillArray(size2,min2,max2);

Console.WriteLine("Второй массив: [ " + String.Join(",", secondArray) + " ]");

Console.WriteLine($"Округлённое среднее арифметическое первого массива: {FindAverageByArray(firstArray)}");
Console.WriteLine($"Округлённое среднее арифметическое второго массива: {FindAverageByArray(secondArray)}");

Console.Write($"Сумма средних арифметических: {FindAverageByArray(firstArray) + FindAverageByArray(secondArray)}");

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

int FindAverageByArray(int[] array)
{
    int sumByElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sumByElements += array[i];
    }
    return sumByElements / array.Length;
}