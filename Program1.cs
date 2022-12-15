// Семинар Урок 2
/*
int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int result = sot * 10 + ed;
    return result;
}
int randNum = new Random().Next(100, 1000);
int newNum = CutNumber(randNum);
Console.WriteLine($"New version of a nuber {randNum} is {newNum}");
*/

// Случайное число из отрезка от 10 до 99 и показывает наибольшую цифру числа.
/*
int Rand(int num)
{
    int ed = num % 10;
    int nextN = num / 10;
    int max = ed;
    if (max < nextN) max = nextN;
    return max;
}
int randNum = new Random().Next(10,100);
int newNum = Rand(randNum);
    Console.WriteLine($"Random Number: {randNum} is nixt number: {newNum}");
*/

// Напишите программу которая на входе принимает число и проверяет, кратно ли оно одновременно a и b.
/*
Console.WriteLine(("Запросить число"));
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Кратно первому"));
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Кратно второму"));
int b = Convert.ToInt32(Console.ReadLine());
void Rand(int num, int a, int b)
{
    if(num % a ==0 && num % b ==0)
    {
        Console.WriteLine("Число равно двум");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}
Rand(num, a, b);
*/

// Напишите программу, котрая на входе принимает 2 числа и проверяет, является ли одно число квадратом другого.
/*
Console.WriteLine(("Запросить число"));
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(("Запросить число"));
int num2 = Convert.ToInt32(Console.ReadLine());
bool Kvadrat(int num1, int num2)
{
    if(num1 * num1 == num2 || num2 * num2 == num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool result = Kvadrat(num1, num2);
Console.WriteLine(($"Результат проверки: {result}"));
*/
//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
*/

//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);
*/