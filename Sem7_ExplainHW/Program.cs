/*Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/

/*Заполнение массива
void FillArray(int[] array)
{
    for (int i = 0 ; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        Console.Write($" {array[i]} ");
        
    }
}
*/
Console.Write("Put Row number  ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Put Column number   ");
int countColumn = int.Parse(Console.ReadLine());

int[,] array = new int [countRow, countColumn];

int arrayRowLength = array.GetLength(0);
int arrayColumnLength = array.GetLength(1);

for (int i = 0; i < arrayRowLength; i ++) // двигается по строкам
{
    for (int j = 0; j < arrayColumnLength; j++ ) // двигается по столбцам
    {
        array[i, j] = new Random().Next(1,11);
    }
}

for (int i = 0; i < countRow; i ++)
{
    for (int j = 0; j < countColumn; j++ )
    {
        Console.Write(array [i, j] + "   ");
    }
    Console.WriteLine();
}
//Вывод суммы 

for (int i = 0; i < countRow; i ++)
{
    int sum = 0;
    for (int j = 0; j < countColumn; j++ )
    {
        sum = sum + array[i,j];
    }
    Console.WriteLine($"In Row {i} sum is: {sum}");
}