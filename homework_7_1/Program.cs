/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
m = 3, n = 4.
0.5 7.96 -2.78 -0.2
1.7 -3.3 8.574 -9.9
8.5 7.87 -7.1 9.15
*/
void FillArray (double [,] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = random.NextDouble()*20-10;
        }
    }
}

void PrintArray (double [,] arr)
{
    for(int i=0; i < arr.GetLength(0); i++)
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {
            Console.Write(Math.Round(arr[i,j], 2) + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

double [,] arr = new double[n,m];

FillArray(arr);
PrintArray (arr);