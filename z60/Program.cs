Console.Clear();

void InputMatrix(int[, , ] matrix)
{
    int number = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            matrix[i, j, k] = number++;
        }
    } 
}

void PrintMatrix(int[, , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) \t");
            Console.WriteLine();
        }
    }
};

Console.WriteLine("Введите размер матрицы: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[, , ] matrix = new int[size[0], size[1], size[2]];

while (size[0] * size[1] * size[2] > 90)
{
    Console.WriteLine("Уменьшите значения размера массива:");
    size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}

InputMatrix(matrix);

PrintMatrix(matrix);