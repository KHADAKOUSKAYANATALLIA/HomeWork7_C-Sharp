/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

double [,] array = new double [m, n];

void CreateArray(double [,] array)
{
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
     for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10));
        }
}
}

void FindAverage(double [,] array)
{
    double [] averageNumber = new double [array.GetLength(1)];
    double sum = 0;
    double average = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
     
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            average = sum / array.GetLength(0);                    
        }
        averageNumber[j] = average;  
        
    Console.WriteLine($"Среднее арифметическое столбца {j}: равно {average.ToString("0.##")}");
    }

}

void PrintArray(double [,] array)
{
     for (int i = 0; i < array.GetLength(0); i++) 
     { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            Console.Write($"{array[i, j]} "); 
        }    
     Console.WriteLine(); }
}

CreateArray(array);
PrintArray(array);
FindAverage(array);
