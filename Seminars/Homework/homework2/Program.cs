// Exercise1

// // System.Console.WriteLine("Please input number :");
// // int number = Convert.ToInt32(Console.ReadLine());
// // if(number%7 == 0 && number%23 == 0)
// // {
// //     System.Console.WriteLine("Numer is kratno to 7 and 23");
// // }
// // else
// // {
// //     System.Console.WriteLine("Number is not kratno to 7 and 23");
// // }

// // Exercise2
// // System.Console.WriteLine("Please input coordinates for x :");
// // int x = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine("Please input coordinates for y :");
// // int y = Convert.ToInt32(Console.ReadLine());
// // if (x > 0 && y > 0)
// // {
// //     System.Console.WriteLine("Point is located in 1 quarter");
// // }
// // else if (x < 0 && y > 0)
// // {
// //     System.Console.WriteLine("Point is located in 2 quarter");
// // }
// // else if (x < 0 && y < 0)
// // {
// //     System.Console.WriteLine("Point is located in 3 quarter");
// // }
// // else if(x < 0 && y < 0)
// // {
// //     System.Console.WriteLine("Point is located in 4 quarter");
// // }
// // else
// // {
// //     System.Console.WriteLine("X or Y is equel to 0");
// // }


// Exercise3

// System.Console.WriteLine("Please input number from 10 to 99 :");
// int num = Convert.ToInt32(Console.ReadLine());
// int x = 0;
// int y = 0;
// x = num / 10;
// y = num % 10;
// if (x > y)
// {
//     System.Console.WriteLine($"{num} -> {x} > {y}");
// }
// else if (y > x)
// {
//     System.Console.WriteLine($"{num} -> {y} > {x}");
// }
// else
// {
//     System.Console.WriteLine("Number is not in 10 - 99 sector ");
// }


//Exercise4

// Console.WriteLine("Please input number N:");
// int number = Convert.ToInt32(Console.ReadLine());
// string len = Convert.ToString(number);
// for (int i = 0; i < len.Length; i++)
// {
//     System.Console.Write(len[i]);
//     if (i < len.Length - 1)
//     {
//         System.Console.Write(", ");
//     }
// }
// System.Console.WriteLine();