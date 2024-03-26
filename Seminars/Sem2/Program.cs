// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81


void MinusSecond (int num)
{
    int ed = num % 10;
    int sot = num / 100;
    System.Console.WriteLine($"{num} -> {sot * 10 + ed}");
}


int MinusSecondInt (int num)
{
    int ed = num % 10;
    int sot = num / 100;
    // System.Console.WriteLine($"{num} -> {sot * 10 + ed}");
    int result = sot * 10 + ed;
    return result;
}

// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

int SecondToThird(int num)
{
     int ed = num % 10;
     int dec = num /10 % 10;
     int res = (int)Math.Pow(dec, ed);
     return res;
}

bool IsThreeDigit(int num)
{
if(num >= 100 && num <= 999)
{
    return true;
}
else
{
    return false;
}
}

// Задание 3. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

void FirstMultipleSecond (int a, int b)
{
    if (a % b == 0)
    {
        System.Console.WriteLine($"{a} kratno {b}");
    }
    else
    {
        System.Console.WriteLine($"{a} ne kratno {b}, ostatok {a % b}");
    }
}

System.Console.WriteLine("Please input first number");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please input second number");
int num2 = Convert.ToInt32(Console.ReadLine());
FirstMultipleSecond(num1,num2);
// System.Console.WriteLine(result);
