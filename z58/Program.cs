Console.Clear();

void InputMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    matrix[i, j] = new Random().Next(1, 21);
}
}




void PrintMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}



Console.WriteLine("Введите размер матрицы (применяется к двум матрицам): ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[, ] matrix1 = new int[size[0], size[1]];

int[, ] matrix2 = new int[size[0], size[1]];

void MultiMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = matrix1[i, j] * matrix2[i, j];
    }
}


InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();

InputMatrix(matrix2);
PrintMatrix(matrix2);

Console.WriteLine();
MultiMatrix(matrix1);
PrintMatrix(matrix1);