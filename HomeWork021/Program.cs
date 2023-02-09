/* Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2   0
5 9 2 3   1
8 4 2 4   2

0 1 2 3
*/

Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine()); // строка i
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine()); // столбец j

int [,] array = new int [m, n];

void FindAverage(int [,] array)
{
    // int average = 0;
    int sum = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    average = 0;

     for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
    average = sum / array.GetLength(1); 
    Console.WriteLine(average + ", ");// ($"Среднее арифметическое столбца {array[i, j]} равно {average}");    
    
}
}

void CreateArray(int [,] array)
{
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
     for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10); 
        }
}
}

void PrintArray(int [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++) 
     { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        }    
     Console.WriteLine(); }
}

FindAverage(array);      
CreateArray(array);
PrintArray(array);

