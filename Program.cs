//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
using System;
class LengthDemo {

public static void Main()
 {   
Console.WriteLine("Введите 5-ти значное число:  ");
int numbers = Convert.ToInt32(Console.ReadLine());
char[]arr = numbers.ToString().ToCharArray();
var a = arr[0];
var b = arr[1];
var c = arr[3];
var d = arr[4];

if (a==d & b==c)
{
Console.WriteLine("Да");
}
else

Console.WriteLine("Нет");

    }
}