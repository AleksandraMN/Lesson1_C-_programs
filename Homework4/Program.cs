﻿/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все чётные числа от 1 до N.
5 -> 2, 4.
8 -> 2, 4, 6, 8. */

Console.Write("Введите целое натуральное число n = ");
int n = Convert.ToInt32(Console.ReadLine());

int index = 1;

while (index <= n)
{
	if (index % 2 == 0)
	{
		Console.WriteLine(index);
	}
	index++;
	}
if (n < 2)
{
	Console.WriteLine("Нет чётных чисел от 1 до N");
}


