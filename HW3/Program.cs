/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
System.Console.Write("Цифра дня недели > ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (num >= 1 && num <= 7)
{
    if (num >= 1 && num <= 5)
    {
        System.Console.WriteLine($"Не выходной день");
    }
    else System.Console.WriteLine("Выходной день");
}
else
    System.Console.WriteLine($"Нет такого дня недели");