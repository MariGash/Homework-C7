/* Задача 3. Необязательная, дополнительная задача Задайте двумерный массив из трехзначных целых чисел
(не менее 100 элементов). В каждом столбце найдите среднее арифметическое среди тех элементов, 
которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0).
Полученные средние арифметические занести в одномерный массив.
Например, задан массив:
100 404 504 225
550 478 800 363
505 101 410 479
=> [505, 252.5, 0, 363 ] */

void FillArray (int [,] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i,j] = random.Next(100, 1000);
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
    Console.WriteLine();
}


Console.Write("Введите число строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] arr = new int[n,m];
double [] result = new double[m];
FillArray(arr);
PrintArray (arr);

double poli = 0;



    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            
            int numberA = arr[i,j] % 10;
            int numberB = arr[i,j] / 100;
            if(numberA == numberB)
            {
                poli = arr[i,j];
                count = count + 1;
            }
            else
            {
                poli = 0;
            }
            sum = sum + poli;
        }
        if(count==0)
        result[j] = 0;
        else
        result[j] = sum / count;
    }
for(int j=0; j < result.Length; j++)
{
    Console.Write(Math.Round(result[j],2) + " ");
}
