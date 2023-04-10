// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

int Matrix(int[,] arrF, int[,] arrS)
{
    int row1 = arrF.GetLength(0);
    int column1 = arrF.GetLength(1);
    int row2 = arrS.GetLength(0);
    int column2 = arrS.GetLength(1);

    int[,] pr_matrix = new int[row1, column1];
    if (column1 != row2) return pr_matrix;
    else if (column1 == row2)
    pr_matrix = new int[row1, column2];
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int n = 0; n < column1; n++)
            pr_matrix[i, j] + arrF[i, n] * arrS[n, j];
        }
    }
    return pr_matrix;
}

Console.Write("Enter the number of rows 1: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 1: ");
int column1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows 2: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 2: ");
int column2 = int.Parse(Console.ReadLine()!);

int[,] arr1 = MassNums(row1, column1, 1, 10);
Print(arr1);
int[,] arr2 = MassNums(row2, column2, 1, 10);
Print(arr2);

int[,] res_matrix = Matrix(arr1, arr2);
Print(res_matrix);