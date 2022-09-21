//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого число

using static System.Console;

Clear();
Write("Введите трехзначное число: ");
int number=int.Parse(ReadLine()!);
int n2 = number/100;
int n1 = (number - n2*100)/10;
WriteLine($"result = {n1}");