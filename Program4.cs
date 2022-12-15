// Семинар Урок 5
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] CreateRandomArray(int size, int minValie, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValie, maxValue +1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Array [{i +1}] is {array[i]} ");
    }
}
// int SumOfNegativs(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] < 0)
//             sum += array[i];
//     return sum;
// }
Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min elemrnts: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max elements: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] userarray = CreateRandomArray(size, min, max);
ShowArray(userarray);
// int result = SumOfNegativs(userarray);
// Console.WriteLine($"Sum of negativ elements is {result}");
*/
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] ReversArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}
int[] revarray = ReversArray(userarray);
ShowArray(revarray);
*/
// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int CountElement(int[] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(a > b)
        {
            if(array[i] >= b && array[i] <= a)
                count++;
            }
            else
            }
             if(array[i] >= a && array[i] <= b)
                count++;
            }
        }
        return count;
}
Console.Write("Input  A ");
int userA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input  B ");
int userB = Convert.ToInt32(Console.ReadLine());
int result = CountElement(userarray, userA, userB);
Console.WriteLine($"Count elements in linessigment {userA} {userB} is {result}");
*/
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*
int[] SumArray(int[] array)
{
    int size = array.Length / 2;
    if(array.Length % 2 != 0 )
        size++;    
    int[] secarray = new int[size];
    for(int i = 0; i < size; i++)
    {
        secarray[i] = array[i] * array[array.Length - i - 1];
    }
    return secarray;
}
Console.WriteLine("");
int[] sumarray = SumArray(userarray);
ShowArray(sumarray);
*/
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;
for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];
    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/