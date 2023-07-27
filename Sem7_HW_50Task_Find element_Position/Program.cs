/*Задача 50: Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] FillRandomArray(int countRow, int countColum)
{
    int[,] array = new int[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array[i, j] = new Random().Next(2, 9);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

//------------------------------------------
int countRow = Prompt("Please put number of Rows");
int countColumn = Prompt("Please put number of Columns");

int [,] array = FillRandomArray(countRow, countColumn);
PrintArray(array);

/*int findNumber = Prompt("Please put a number you want to find");
if (findNumber > countColumn * countRow) 
{
    Console.WriteLine("There is no such number in array");
}
else 
{
    Console.Write(findNumber - 1 / countRow);
    Console.Write(findNumber - 1 % countRow);
    
    //($"The position of your element in array is {array[findNumber -1]/ countRow, array[findNumber - 1] % countColumn} ");
}    
*/
int number = Prompt("Введите номер элемента");
if (number > countColumn * countRow)
{
    Console.WriteLine("Элемента с таким индексом нет в массиве");
}
else
{
    //Console.WriteLine((number - 1) / countRow);
    //Console.WriteLine((number - 1) % countColum);
    Console.WriteLine($"Заначение элемента {array[(number - 1) / countRow, (number - 1) % countColumn]}");
}