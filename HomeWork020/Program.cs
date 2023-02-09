/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указывает, 
что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1(строка) 7(столбец) -> такого числа в массиве нет.
*/

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
Console.WriteLine("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine()); // строка
Console.WriteLine("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine()); // столбец

int [,] array = new int [m, n];

CreateArray(array);
PrintArray(array);
Console.WriteLine("На проверку введите позицию элемента в строке массива: "); 
int a = Convert.ToInt32(Console.ReadLine()); // строка
Console.WriteLine("На проверку введите позицию элемента в столбце массива: "); 
int b = Convert.ToInt32(Console.ReadLine()); // столбец

if(a > array.GetLength(0)-1 || b >array.GetLength(1)-1)
{
    Console.WriteLine("Такого элемента нет!");
}
else 
{
    Console.WriteLine($"Значение элемента массива с координатами [{a},{b}] = {array[a, b]}");
}




      

