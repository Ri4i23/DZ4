﻿// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

while(number > 0)
{
    result = result + number % 10;
    number = number / 10;
}
Console.WriteLine(result);