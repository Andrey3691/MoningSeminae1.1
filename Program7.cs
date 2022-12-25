// Семинар Урок 8

/*
int[,] CreateRandom2dArray()
{   
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/
// Задача1: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
/*
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
void Reverse2dArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Reverse2dArray(myArray);
Show2dArray(myArray);
*/
// Задача1: Задайте двумерный массив. Напишите программу, которая поменяет местами любые 2 строки массива.
/*
void CreateNewArray(int[,] array, int numA, int numB)
{
    if( numA != numB && numA >= 0 && numB >= 0 && numA < array.GetLength(0) && numB < array.GetLength(0))
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[numA,j];
            array[numA,j] = array[numB,j];
            array[numB,j] = temp;
        }
    }
    else Console.WriteLine("No row");
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine("Input first row");
int indA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second row");
int indB = Convert.ToInt32(Console.ReadLine());
CreateNewArray(myArray, indA, indB);
Show2dArray(myArray);
*/
// Задача2: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
int[] MinElement(int[,] array)
{
    int[] min = new int[2];
    int temp = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < temp)
            {
                temp = array[i,j];
                min[0] = i;
                min[1] = j;
            }
        }
    }
    return min;
}
int[,] CutArray(int[,] array, int minI, int minJ)
{
    int[,] cutArray = new int [array.GetLength(0)- 1, array.GetLength(1) - 1];
    for(int i = 0, x = 0; i < array.GetLength(0);i++, x++)
    {
        if(i != minI)
        {
            for(int j = 0, y = 0; j < array.GetLength(1);j++, y++)
            {
                if( j != minJ)
                {
                    cutArray[x,y] = array[i,j];
                }
                else y--;
            }
        }
        else x--;
    }
    return cutArray;
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[] minArray = MinElement(myArray);
int[,] cutNewArray = CutArray(myArray, minArray[0], minArray[1]);
Show2dArray(cutNewArray);
*/
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");
int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);
Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);
void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
*/
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");
int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
*/
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);
int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);
int[,] resultMatrix = new int[m,p];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
*/
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");
int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/
// Напишите программу, которая заполнит спирально массив 4 на 4.
/*
void Spiral<T>(T[,] arr)
{
  int n = arr.GetLength(0);
  int count = n; 
  int value = -n;
  int sum = -1;
  do
  {
      value = -1 * value / n;
      for (int i = 0; i < count; i++)
      {
          sum += value;
          Console.Write(arr[sum / n, sum % n] + " ");
      }
      value *= n;
      count--;
      for (int i = 0; i < count; i++)
      {
          sum += value;
          Console.Write(arr[sum / n, sum % n] + " ");
      }
  } 
  while (count > 0);
}
void Main()
{
  var strArr = new string[4, 4];
  for (int i = 0; i < 4; i++)
    for (int j = 0; j < 4; j++)
      strArr[i, j] = Console.ReadLine()!; // Здесь вводим символы
      Spiral(strArr);
      Console.WriteLine();
  var intArr = new int[4, 4];
  for (int i = 0; i < 4; i++)
    for (int j = 0; j < 4; j++)
  intArr[i, j] = int.Parse(Console.ReadLine()!); // Здесь вводим цифры
  Spiral(intArr);
}
*/