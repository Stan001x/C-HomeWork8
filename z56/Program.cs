Console.Clear();

void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j =0; j < matrix.GetLength(1); j++)
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

int SumMatrix(int[, ] matrix)
{
    int minRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        minRow = minRow + matrix[0, j];
        int minRowIndex = 1;

    for (int i = 1; i < matrix.GetLength(0); i++)
    {   
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumRow = sumRow + matrix[i, j];
        if (sumRow < minRow)
        minRowIndex = i + 1;
        
    }
    return minRowIndex;
};

Console.WriteLine("Введите размер массива: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int[, ] matrix = new int[size[0], size[1]];

while (size[0] == size[1])
{
    Console.WriteLine("Вы ошиблись. Введите размер прямоугольного массива: ");

size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}

InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Наименьшая сумма элементов в строке: {SumMatrix(matrix)}");