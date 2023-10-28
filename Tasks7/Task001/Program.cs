// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Пример: m = 3, n = 4.
//         0,5 7 -2 -0,2
//         1 -3,3 8 -9,9
//         8 7,8 -7,1 9

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
// Матрица - таблица, размером m(кол-во строк) на n (кол-во столбцов)
// minValue - мин. число для рандома, maxValue - макс. число для рандома  

double[,] GetDoubleMatrix(int m, int n)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2); 
        }
    }
    return matrix;
}

void PrintDoubleMatrix(double[,] matr)
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
double[,] array2D = GetDoubleMatrix(rows, columns);
PrintDoubleMatrix(array2D);