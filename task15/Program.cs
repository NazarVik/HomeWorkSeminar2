// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("введите  день недели от 1 до 7 = ");
int day = int.Parse(Console.ReadLine());

if ((day == 6) || (day == 7)) Console.WriteLine(day + " -> да");
else Console.WriteLine(day + " -> нет");
