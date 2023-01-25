/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.Write("ВВедите число > ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num > 99)
{
    int result = num % 10;
    System.Console.WriteLine($"Третья цифра числа {num} равна {result}");
}
else
    System.Console.WriteLine($"Третьей цифры нет");