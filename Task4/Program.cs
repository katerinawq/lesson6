/*Задача 44: Не используя рекурсию, выведите первые N чисел
 Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

Console.Write("Введите число для которого будет построен ряд Фибоначчи: ");
int fiblim = int.Parse(Console.ReadLine());
int [] fib = new int [fiblim];
fib[0]=0;
fib[1]=1;

for (int i=2; i<fiblim; i++)
{
fib[i]=fib[i-2]+fib[i-1];
}
PrintArray(fib);
