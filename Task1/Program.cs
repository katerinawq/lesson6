/* Демонстрация решения
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]*/

int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)   
{
mass[i] = new Random().Next(0, 10);
}
for (int i = 0; i < mass.Length; i++)
{
Console.Write(mass[i] + " ");
}
Console.WriteLine();

/* Создали Массив. */
 for (int i = 0; i < mass.Length / 2; i++)
 {
    int save = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = save;   // mass.Lenght - 1 -последний элемент массива
 }                                      //mass.Lenght - i - чтобы сдвинуть последний элемент
  for (int i = 0; i < mass.Length ; i++)
 {
    Console.Write(mass[i] + " ");  
 }
 Console.WriteLine();

// Массив переворачивается
