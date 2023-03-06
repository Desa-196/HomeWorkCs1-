/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

int N = 0;

Console.Write("Введите число N: ");

while(  !int.TryParse(Console.ReadLine(), out N ))
{
    Console.Write("Введено некорректное число, повторите попытку ввода: ");
}

Console.WriteLine($"Список четных чисел от 1 до {N}:");

//Если N больше нуля
if(N > 0)
{
    for(int i=2; i <= N; i= i+2 )
    {
        Console.WriteLine(i);
    }
}
//Если N меньше или равно нулю.
else
{
    for(int i=0; i >= N; i=i-2 )
    {
        Console.WriteLine(i);
    }
}
