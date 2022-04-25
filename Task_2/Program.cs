// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


int rows = 5;
int columns = 5;
int[,] array = new int[rows, columns];

FillArray();
PrintArray();
SortingArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}

void PrintArray()
{
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortingArray()
{
    double min_sum = 40;
    int index_min_sum = -1;
    for (int i = 0; i < rows; i++)
    {
        double current_sum = 0;
        for (int j = 0; j < columns; j++)
        {
            current_sum += array[i, j];
        }
        if (current_sum < min_sum)
        {
            min_sum = current_sum;
            index_min_sum = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов находится в строке {index_min_sum}  и равна {min_sum}");
}






