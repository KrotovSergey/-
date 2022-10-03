//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Какую задачу проверить?: 34/36/38 ");

int zadacha = int.Parse(Console.ReadLine());

if (zadacha == 34)
{
    Zadacha1();
}
else if (zadacha == 36)
{
    Zadacha2();
}
else if (zadacha == 38)
{
    Zadacha3();
}


void Zadacha1()
{
    Console.WriteLine("Введите размер массива: ");

    int size = int.Parse(Console.ReadLine());

    int[] Array = FillArray(size);

    int count = 0;

    Console.WriteLine("массив: [ " + String.Join(",", Array) + " ]");

    
   
    int[] FillArray(int size)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(100, 999);
    }
    return filledArray;
}
    

    for (int i = 0; i<Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        count = count +1;
    }
    
    Console.WriteLine($"Количество четных элементов= {count}");

}
void Zadacha2()
{
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine());

    int SumNumber(int a)
    {
        int counter = Convert.ToString(a).Length;
        int advance = 0;
        int result = 0;
        for (int i = 0; i < counter; i++)
        {
            advance = a - a % 10;
            result = result + (a - advance);
            a = a / 10;
        }
        return result;
    }
    int sumNumber = SumNumber(a);
    Console.WriteLine("Сумма цифр в заданном числе: " + sumNumber);

}

void Zadacha3()
{
    Console.Write("Из скольки чисел вы хотите увидеть массив?: ");

    int a = int.Parse(Console.ReadLine());

    int[] arr = new int[a];

    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    Console.WriteLine(string.Join(", ", arr));

}