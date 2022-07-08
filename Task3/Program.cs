/*Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.*/

Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine());
int ost = 0;
string result = string.Empty;
while (numb > 0)
{
   ost = numb % 2;
   numb = numb / 2;
   result = ost + result; 
}
Console.WriteLine(result);