// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("введите  число = ");
int number = int.Parse(Console.ReadLine());

 if (number < 100) Console.WriteLine(number + " -> третьей цифры нет");
 else
 {
    while (number > 1000) number = number / 10;
    int rezult = number % 10;
    Console.WriteLine(number + " -> " + rezult);    
 }


