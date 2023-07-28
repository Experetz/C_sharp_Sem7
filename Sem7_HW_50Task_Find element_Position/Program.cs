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

string FindValueNumber (int [,] array, int i, int j)
{
    if ((i >=  array.GetLength(0) || i <= 0) || (j >=  array.GetLength(1) || j <= 0))
    {
        string message = "There is no such element in array";
        return message;
    }
    else 
    {
        int temp = array[i,j];
        string strvalue = temp.ToString();
        return strvalue;
    }
}

//------------------------------------------
int stringposition = Prompt("Please put position in Rows");
int columnposition = Prompt("Please put position in Columns");

int [,] array = FillRandomArray(4, 5);
PrintArray(array);
string value = FindValueNumber(array, stringposition, columnposition);
Console.WriteLine($"The value of requested number is {value}");

