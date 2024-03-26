// Совместная работа
// Семинар 3. Массивы
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();

}

// bool FindNumber(int num, int[] array)
// {
//     foreach (int item in array)
//     {
//         if (item == num)
//         {
//             return true;
//         }

//     }
//     return false;
// }

// int[] SignInvert(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * -1;
//     }

//     return arr;
// }

int[] CreateNewArray(int[] array)
{
    int[] array2 = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        array2[i]= array[i]*array[array.Length-1-i];
    }
    return array2;
}

System.Console.WriteLine("Please input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
// System.Console.WriteLine("Input num wants to find");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindNumber(num, arr));
PrintArray(CreateNewArray(arr));

// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5]