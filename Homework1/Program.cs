﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Write("Введите целое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b = ");
int b = Convert.ToInt32(Console.ReadLine());

int max = a, min = b;

if (a < min) 
{
	min = a; 
	max = b;
}

if (a > min) 
{
	min = b; 
	max = a;
}

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);


