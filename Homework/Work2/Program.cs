System.Console.WriteLine("Please input number");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"{7} and {23} is ktratno {num}");
}
else
{
    System.Console.WriteLine($"{7} and {23} is no ktratno {num}");
}