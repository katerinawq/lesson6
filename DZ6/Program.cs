//-----------------------------------------------------------------------------------------------
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//-----------------------------------------------------------------------------------------------
Console.Write("Введите массив: ");
string arrayString = Console.ReadLine().Trim(' '); 
string [] arraySplit = arrayString.Split(',', ' ');
int [] arrayInt = new int [arraySplit.Length] ;

Console.Write("Введенный массив: ");
for (int i=0; i<arraySplit.Length; i++)
{
    arrayInt[i]=int.Parse(arraySplit[i]);
    Console.Write($" {arrayInt[i]}");    
}
Console.WriteLine();

int count2=0;
for (int i=0; i<arrayInt.Length; i++)
{
    if (arrayInt[i]>0)
    {
        count2++;
    }    
}

Console.WriteLine($"Количество положительных элементов в массиве равно: {count2}");


//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("Данная программа находет пересечение прямых вида y=ax+b");
Console.Write("Введите коэффициент k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double b2 = double.Parse(Console.ReadLine());

if (k1 == k2) { Console.Write("Описанные прямые паралельны, пересечение отсутствует."); }
else
{
    double x = (b2 - b1) / (k1 - k2);
    Console.Write($"Координаты точка пересечения описанных прямых: x={x}, y={k1 * x + b1}.");
}