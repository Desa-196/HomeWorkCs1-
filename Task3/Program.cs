/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

int int_1 = 0;

Console.WriteLine("Введите число для проверки четности: ");

while(  !int.TryParse(Console.ReadLine(), out int_1 ))
{
    Console.Write("Введено некорректное число, повторите попытку ввода: ");
}

if( int_1 % 2 == 0) Console.WriteLine($"Чило {int_1} является четным.");
else Console.WriteLine($"Чило {int_1} является не четным.");
