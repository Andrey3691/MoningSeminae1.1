// Семинар Урок 3
/*
int FindQuadrand (double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Input an x-coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y-coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());
int qadNum = FindQuadrad(xA, yA);
Console.WriteLine($"The point A {xA},{yA} is on the {qadNum} qadRand");
*/


/*
int GetCoordinates(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x>0, y>0");
    else if(quadrant == 2) Console.WriteLine("x<0, y>0");
    else if(quadrant == 3) Console.WriteLine("x<0, y<0");
    else if(quadrant == 4) Console.WriteLine("x>0, y<0");
    else Console.WriteLine("There is on such quadrant");
}
Console.WriteLine("Input number is the quadrant: ");
int quadrantPoits = Convert.ToInt32(Console.ReadLine());
GetCoordinates(quadrantPoits);
*/

/*
void GetCoordinates(int quadrant)
{
    if(quadrant == 1) Console.WriteLine("x>0, y>0");
    else if(quadrant == 2) Console.WriteLine("x<0, y>0");
    else if(quadrant == 3) Console.WriteLine("x<0, y<0");
    else if(quadrant == 4) Console.WriteLine("x>0, y<0");
    else Console.WriteLine("There is on such quadrant");
}
Console.WriteLine("Input number is the quadrant: ");
int quadrantPoits = Convert.ToInt32(Console.ReadLine());
GetCoordinates(quadrantPoits);
*/

/*
double Distance(double xA, double yA, double xB, double yB)
{
    double Lingh = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
    return Math.Round(Lingh, 2);
}
Console.WriteLine("Input an x-coordonate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordonate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an x-coordonate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an y-coordonate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());
double distanceBetweenAB = Distance(xA, xB, yA, yB);
Console.WriteLine("Distance Between points A and B is {distanceBetweenAB}.");
*/

/*
void Squares(int number)
{
    int counter = 1;
    while(counter <= number)
    {
    Console.Write(Math.Pow(counter, 2));
    if(counter != number) Console.Write(", ");
    counter ++;
    }
}
Console.WriteLine("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The series of squares of numbers:");
Squares(num);
*/

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Введите число: ");
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}
double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Длина отрезка  {segmentLength}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/