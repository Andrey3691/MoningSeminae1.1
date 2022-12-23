// Семинар Урок 7
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minVolue, int maxVolue)
{
    int [,] array = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVolue, maxVolue + 1);
    return array;
}
void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}
Console.Write("Input a number rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
*/
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

// int[,] ArrayIJ()
// {
//     Console.Write("Input number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)    
//         for(int j = 0; j < columns; j++)
//             array[i,j] = i + j;

//     return array;
// }

// int[,] userArray = ArrayIJ();
// Show2DArray(userArray);


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// void QuadEvenElements(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i += 2)
//         for(int j = 0; j < array.GetLength(1); j +=2)
//             array[i,j] *= array[i,j];
// }

// QuadEvenElements(userArray);

// Show2DArray(userArray);


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int SumDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(1) && i < array.GetLength(0); i++)
        sum += array[i,i];
    return sum;
}
int userSum = SumDiag(userArray);
Console.WriteLine(userSum);
*/
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { 
    for (int j = 0; j < n; j++)
    { 
        Console.Write($"{matr[i, j]} ");
    }
 Console.WriteLine();
 }
 }
 void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
    { 
        matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
    }
 }
}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);
*/
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }
 */
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.WriteLine("Введите размер матрицы:");
    int N = int.Parse(Console.ReadLine()!);
    int M = int.Parse(Console.ReadLine()!);
    int[,] matrix = new int[N, M];
    Random rand = new Random();
    int[] summ = new int[M];
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    Console.WriteLine("Матрица");
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
                  
            Console.Write(matrix[i, j]);
            summ[i] += matrix[j, i];     
        } 
        Console.WriteLine();
    }
    Console.WriteLine();
    foreach (double elem in summ)
    {
                
        Console.WriteLine(elem/M);
    }
*/