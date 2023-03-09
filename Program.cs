﻿/* Урок 3. Базовые алгоритмы. Продолжение
Задача 19
 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int reversedinteger = 0, remainder,originalInteger;
originalInteger = number;

while (number != 0){
    remainder = number % 10;
    reversedinteger = reversedinteger * 10 + remainder;
    number /= 10;
}
if(originalInteger == reversedinteger){
    Console.Write($"Палиндром: {originalInteger} ");
}
else{
    Console.Write($"не палиндром: {originalInteger} ");
}

Задача 21 (branch task_2)
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {length}");


 Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i} ");
}



 Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
/*