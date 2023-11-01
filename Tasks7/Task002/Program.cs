// Задача № 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Пример: задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,cols];
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

int FindElements(int[,] matr, int x, int y)
{
    int res = 0;
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
                res = matr[x - 1, y - 1];
        }
    }         
   
return res;
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array2D = GetMatrix(rows, cols, 0, 10);
PrintMatrix(array2D);

Console.WriteLine("Введите номер строки, где должен находиться искомый элемент: ");
int x = (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите номер столбца, где должен находиться искомый элемент: ");
int y = (Convert.ToInt32(Console.ReadLine()));
if (x <= rows || y <=  cols)
{
    Console.WriteLine($"Значение элемента двумерного массива с позициями [{x}, {y}] -> {FindElements(array2D, x, y)}.");
}         
    else Console.WriteLine("Такого элемента в массиве нет!");