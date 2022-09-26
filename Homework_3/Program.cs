Console.Clear();

Console.WriteLine("Какую задачу проверить?: 19/21/23 ");

int zadacha = int.Parse(Console.ReadLine());

if (zadacha == 19) {
    Zadacha1();
    }
    else if (zadacha == 21) {
        Zadacha2();
    }
    else if(zadacha == 23)
    {
        Zadacha3();
    } 


void Zadacha1(){
    Console.Clear();

    Console.WriteLine("Введите 5-ти значное число:");

    int num = int.Parse(Console.ReadLine());

    int a = num/10000;
    
    int b = num%10;

    int c = (num - (num/10000)*10000);
  
    int d = (c - (c%10))/10;


    int e  = d/100;

    int f = d%10;
  
    if(a == b && e == f) {
        Console.WriteLine("это число является палиндромом");
    }
    else
            {
                Console.WriteLine("это число не является палиндромом");
            }
} 

void Zadacha2(){
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

double r = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)+ Math.Pow(zb - za, 2));

Console.WriteLine($"Расстояние равно {Math.Round(r, 3)}");

}

void Zadacha3(){
    Console.WriteLine("Введите число: ");

    int a = int.Parse(Console.ReadLine());

    int b = 1;

    while( b<a)
    {
    Console.WriteLine(Math.Pow(b,3));
    b++;
    }
}