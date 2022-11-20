Console.Clear();
Console.WriteLine("введите количество строк");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int l = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[k,l];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            array[x, y] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        Console.Write("[ ");
        for (int y = 0; y < array.GetLength(1); y++)
        {
            Console.Write(array[x, y] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
