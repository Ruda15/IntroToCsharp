// Console.WriteLine("What is your name?");
// string name = Console.ReadLine();
// Console.WriteLine("Hello " + name + "!");
// System.Console.WriteLine("How old are you?");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(age * age);

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// System.Console.WriteLine("Please input nuber 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Please input number 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 * num2 == num1)
// {
//     System.Console.WriteLine($"{num2} is quad of {num1}");
// }
// else
// {
//     Console.WriteLine($"{num2} is not quad of {num1}");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// System.Console.WriteLine("Please input nuber");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = -num;

// while (count <= num)
// {
//     System.Console.Write(count + " ");
//     count++;
// }



// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

System.Console.WriteLine("Please input three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
if(num >= 100 && num <= 999)
{
    int ed = num % 10;
    int sot = num / 100;
    Console.Write($"{num} -> {ed + sot}");
}
else
{
    System.Console.WriteLine("you input not three-digit number");
}