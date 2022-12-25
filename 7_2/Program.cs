/* Задача 2. Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет */

void FillArray (int [,] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = random.Next(1, 10);
        }
    }
}

void PrintArray (int [,] arr)
{
    for(int i=0; i < arr.GetLength(0); i++)
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] arr = new int[n,m];

FillArray(arr);
PrintArray (arr);
Console.WriteLine();

Console.Write("Введите строку нахождения числа: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию числа в строке: ");
int y = Convert.ToInt32(Console.ReadLine());

if(y-1 < m && x-1 < n && y > 0 && x > 0)
{
    Console.WriteLine(arr[x-1, y-1]);
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}