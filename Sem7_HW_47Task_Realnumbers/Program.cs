/*Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[,] GetRandomArray(int countRow, int countColum)
{
    double[,] array = new double[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-10, 11), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//_________________________

int countRow = Prompt("Please put number of Rows");
int countColumn = Prompt("Please put number of Columns");

double[,] array = GetRandomArray(countRow, countColumn);
PrintArray(array);



