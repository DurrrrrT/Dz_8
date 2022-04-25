// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива(в пределах всего массива).

System.Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
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
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                if (array[i, k] < array[i, j])
                {
                    int temp = array[i, j];
                    array [i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }   
        }
    }
     PrintArray();
}




























