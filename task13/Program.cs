/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if ( 100 <= num & num < 1000 ){
int secondDigit = num % 10;
Console.WriteLine($"{secondDigit}");
}
if ( 1000 <= num & num < 10000) {
int thirdDigit = num / 10 ;
int firstDigit = thirdDigit % 10;
Console.WriteLine($"{firstDigit}");
}
if (10000 <= num & num < 100000)
{
int forthDigit = num / 100;
int fiveDigit =  forthDigit % 10;
Console.WriteLine($"{fiveDigit}");
}
if ( num < 100 )
Console.WriteLine("третьей цифры нет");


