// Семинар Крок 6
/*
int [] CreateRandomArray (целый размер, int minValue, int maxValue)
{
    массив int[] = новый int[size];
    for(int я = 0; я < размер; я ++)
         array[i] = new Random().Next(minValue, maxValue + 1);
    возвращаемый массив;
}
недействительным ShowArray ( массив int [] )
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(массив [i] + " ");
    }
    Консоль.ЗаписьЛинии();
}
*/
// Задача1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
void ReverseArray (массив int [])
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        интервал времени = массив [i];
        массив[i] = массив[j];
        массив [j] = темп;
    }
}
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(размер, мин., макс.);
ПоказатьМассив(МойМассив);
Обратный массив (мой массив);
ПоказатьМассив(МойМассив);
*/

// Задача2.
/*
логический треугольник (int a, int b, int c)
{
    вернуть a < b + c && b < a + c && c < a + b;
}
Console.Write("Введите длину a: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину b: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину c: ");
int sideC = Convert.ToInt32(Console.ReadLine());
логический результат = треугольник (сторона A, сторона B, сторона C);
Console.WriteLine(результат);
*/

// Задача3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fib(целый размер, int a, int b)
{
    int [] newArray = новый int[size];
    новый массив [0] = а;
    новый массив [1] = б;
    for(int я = 2; я < размер; я ++)
    {
        новыймассив[i] = новыймассив[i-1] + новыймассив[i-2];
    }
    вернуть новый массив;
}
Console.Write("Входной размер: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[] fib = Fib(размер, число1, число2);
ПоказатьМассив(фиб);
*/
// Задача 1: Напишите программу, которая будет создавать заданный массив с помощью поэлементного сайта.
/*
int[] Копировать (int[] массив)
{
    int[] newArray = новый int[array.Length];
    for(int i = 0; i < array.Length; i++)
        новый массив [я] = массив [я];
    вернуть новый массив;
}
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(размер, мин., макс.);
ПоказатьМассив(МойМассив);
int[] copyArray = Копировать (мой массив);
ПоказатьМассив(КопироватьМассив);
мойМассив[мойМассив.Длина - 1] +=10;
ПоказатьМассив(МойМассив);
*/
// Пользователь вводит с клавиатуры M чисел. Почитайте, сколько чисел больше 0 ввёл пользователей.
/*
Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine()!);
РаспечататьМассив(числа);
целая сумма = 0;
for (int i = 0; i < numbers.Length; i++)
{
    если (числа [i] > 0)
    {
        сумма++;
    }
}
Консоль.ЗаписьЛинии();
Console.WriteLine($"количество значений больше 0 = {сумма}");
int[] StringToNum(строковый ввод)
{
    количество счетчиков = 1;
    for (int i = 0; i < input.Length; i++)
    {
        если (ввод [i] == ',')
        {
            количество++;
        }
    }
    int[] number = новый int [количество];
    внутренний индекс = 0;
    for (int i = 0; i < input.Length; i++)
    {
        временная строка = "";
        пока (введите [i] != ',')
        {
        если (я != ввод.Длина - 1)
        {
            temp += input [i].ToString();
            я++;
        }
        еще
        {
            temp += input [i].ToString();
            сломать;
        }
        }
        числа [индекс] = Convert.ToInt32 (temp);
        индекс++;
    }
    номера возврата;
}
недействительным PrintArray (массив int [])
{
    Консоль.Написать("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(массив[i] + " ");
    }
    Console.Write("]");
}
*/
// Напишите программу, которая найдёт точку пересечения двух полномочий, заданных задачами y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.WriteLine("включить значение b1");
двойной b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
двойной k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("включить значение b2");
двойной b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
двойной k2 = Convert.ToInt32(Console.ReadLine());
двойной х = (-b2 + b1)/(-k1 + k2);
двойной у = k2 * x + b2;
Console.WriteLine($"две прямые пересекутся с координатами X: {x}, Y: {y}");
*/