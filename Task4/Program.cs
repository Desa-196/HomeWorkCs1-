int N = 0;
Console.WriteLine("Введите число N: ");

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
