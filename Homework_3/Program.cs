Console.Clear();

Console.WriteLine("Какую задачу проверить?: 19/21/23 ");

int zadacha = int.Parse(Console.ReadLine());

if (zadacha == 19) {
    Zadacha1();
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

void Zadacha2()