// Задача № 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Пример: задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System.Reflection.PortableExecutable;

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// bool CheckLines(int x, int y, double b2, double k2)
// {
//     if (k1 == k2)
//     {
//         if (b1 == b2)
//         {
//             Console.WriteLine("Прямые совпадают!");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine("Прямые параллельны!");
//             return false;
//         }
//     }
//     return true;
// }



int FindElements(int[,] matr)
{
    Console.WriteLine("Введите номер строки, где должен находиться искомый элемент: ");
    int x = (Convert.ToInt32(Console.ReadLine()) - 1);
    Console.WriteLine("Введите номер столбца, где должен находиться искомый элемент: ");
    int y = (Convert.ToInt32(Console.ReadLine()) - 1);
    int res = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (x == i)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (y == j)
                {
                    res = matr[x, y];
                }
            }
        }
        else
        {
            Console.WriteLine("Такого элемента в массиве нет!");
        }
    }
    return res;
}


int[,] array2D = GetMatrix(rows, columns, 0, 10);
PrintMatrix(array2D);
Console.WriteLine($"-> {FindElements(array2D)}");
