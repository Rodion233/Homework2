﻿/*Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
Не использовать строки для расчета.*/

Random rnd = new Random();
int number = rnd.Next(100, 999);
System.Console.WriteLine(number);
int num1 = (number / 100) % 10;
int num2 = number % 10;
int number1 = int.Parse(num1.ToString() + num2.ToString());
System.Console.WriteLine($"Случайное число {number}, число без второй цифры {number1}");