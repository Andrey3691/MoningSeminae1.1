// Семинар Урок 1
// Задача 1. Напишите программу котрая на входе принимает два числа и 
/*
Console.Write("Input a First number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int quad = num2 * num2;
if(num1 == quad)
{
    Console.WriteLine("Yse!");
}
else
{
    Console.WriteLine("No!");
}
*/
// Задача 2. Напишите программу, корорая на входе принимает число {N}, а на выходе число
/*
Console.Write("Iput a interger nember: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = -num;
while(current <= num)
{
    Console.Write(current + " ");
    current ++;
}
*/

// Задача2:Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Всего чисел : ");
int n = Convert.ToInt32(Console.ReadLine());
int Nmin = 0;
int Nmax = 0;
int a;
Console.Write("число : ");
a = Convert.ToInt32(Console.ReadLine());
int min = a;
int max = a;
for (int i = 1; i < n; i++)
{
    Console.Write("число : ");
      a = Convert.ToInt32(Console.ReadLine());
      if (a <= min)
      {
        min = a;
         Nmin = i;
      }
      if (a >= max)
      {
        max = a;
         Nmax = i;
      }
}
Console.WriteLine($"Номер минимального числа - {Nmin + 1},  Номер максимального числа - {Nmax + 1}.");        
Console.ReadKey();
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Всего чисел : ");
int n = Convert.ToInt32(Console.ReadLine());
int Nmin = 0;
int Nmax = 0;
int a;
Console.Write("число : ");
a = Convert.ToInt32(Console.ReadLine());
int min = a;
int max = a;
for (int i = 1; i < n; i++)
{
    Console.Write("число : ");
      a = Convert.ToInt32(Console.ReadLine());
      if (a <= min)
      {
        min = a;
         Nmin = i;
      }
      if (a >= max)
      {
        max = a;
         Nmax = i;
      }
}
Console.WriteLine($"Номер минимального числа - {Nmin + 1},  Номер максимального числа - {Nmax + 1}.");        
Console.ReadKey();
*/
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("число : ");
int a;
a = Convert.ToInt32(Console.ReadLine());
int temp = a % 2;
bool result = temp == 0;
if (result)
{
     Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
*/
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число n: ");
int n;
n = Convert.ToInt32(Console.ReadLine());
for (int i = n; i <= n; i++)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
	}
}
Console.ReadKey();
*/