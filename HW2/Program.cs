/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.Write("Введите число > ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
double len = Convert.ToDouble(number.Length);
double st = Math.Pow(10, (len - 3));
int stepen = Convert.ToInt32(st);
if (num > 99)
{
    int result = num / stepen % 10;
    System.Console.WriteLine($"Третья цифра числа {num} равна {result}");
}
else
    System.Console.WriteLine($"Третьей цифры нет");