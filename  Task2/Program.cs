/*Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.*/

Console.WriteLine("Введите 3 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine("Треугольник существует");
}

else Console.WriteLine ("No");