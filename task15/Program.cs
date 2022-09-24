/* Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num <= 5)
Console.WriteLine($"{num} -> нет");

if (num == 6)
Console.WriteLine($"{num} -> да");

if (num == 7)
Console.WriteLine($"{num} -> да");
