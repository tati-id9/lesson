﻿/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */
Console.WriteLine ("Ввведите число:");
int N = int.Parse(Console.ReadLine());
if (N>=10000 && N<100000)
{
    Palindrome (N);
}
else
{
    Console.WriteLine ("Вы ввели не верное число, число должно быть пятизначным");
}

void Palindrome (int number)
{
    if (((number/10000) == (number%10)) && ((number/1000%10) == (number%100/10)))
    {
        Console.WriteLine ($"Число {number} - является палиндромом");
    }
    else
    {
        Console.WriteLine ($"Число {number} - не является палиндромом");
    }
}

/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */