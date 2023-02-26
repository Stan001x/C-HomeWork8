Console.Clear();

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21);
    }
};

void PrintMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
            Console.WriteLine();
        }
};

void FilterMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1) - 1; n++)
                if (matrix[i, n] < matrix[i, n +1 ])
                {int temp = matrix[i, n];
                matrix[i, n] = matrix[i, n + 1];
                matrix[i, n + 1] = temp;}
        }
    }
};

Console.WriteLine("Введите размер массива: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[, ] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FilterMatrix(matrix);
PrintMatrix(matrix);
