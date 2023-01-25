/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
System.Console.Write("Трехзначное число > ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num > 99 && num < 1000)
{
    int result = (num / 10) % 10;
    System.Console.WriteLine($"Вторая цифра числа {num} равна {result}");
}
else
    System.Console.WriteLine($"Число не трехзначное");