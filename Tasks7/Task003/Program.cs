// Задача № 52.
// Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
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

double[] FindSredArifColomns(int[,] matr)
{
    double[] srednee = new double[matr.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
           sum = sum + matr[i, j]; 
        }
        srednee[j] = sum / matr.GetLength(0);
    }
    return srednee;
}

int[,] array2D = GetMatrix(rows, columns);
PrintMatrix(array2D);
double[] sredneeArr = FindSredArifColomns(array2D);
Console.Write("[" + string.Join(", ", sredneeArr) + "]");