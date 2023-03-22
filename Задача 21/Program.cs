// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Задайте координаты двух точек в трёхмерном прострнстве");

System.Console.WriteLine("Задайте высоту первой точки");
double dotOneX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Задайте широту первой точки");
double dotOneY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Задайте глубину первой точки");
double dotOneZ = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Задайте высоту второй точки");
double dotTwoX = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Задайте широту второй точки");
double dotTwoY = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Задайте глубину второй точки");
double dotTwoZ = Convert.ToDouble(Console.ReadLine());

double lengthX = Math.Pow(dotOneX - dotTwoX, 2);
double lengthY = Math.Pow(dotOneY - dotTwoY, 2);
double lengthZ = Math.Pow(dotOneZ - dotTwoZ, 2);

double result = Math.Round(Math.Sqrt(lengthX + lengthY + lengthZ), 2);

System.Console.Write("Расстояние между точками равно " + result);
