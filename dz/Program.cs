﻿//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void Mas(int m)
{
    for (int i = 0; i < m; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}

}

int Kol(int[] Array)
{
    int i=0;
    int sum = 0;
while (i < Array.Length)
{
    if(Array[i]>0)
    sum = sum + 1;
    i ++;
}
return sum;
}

Mas(m);
Console.Write($"Чисел больше нуля: {Kol(Array)}");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

/*Console.WriteLine("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите переменную k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
Console.WriteLine("Прямые совпадают");
else if (k1==k2)
Console.WriteLine("Прямые параллельны");
else
{
double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;
Console.Write($"\n Точка пересечения двух прямых: [{x},{y}]");
}
*/
