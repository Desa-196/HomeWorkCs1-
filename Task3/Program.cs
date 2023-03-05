int int_1 = 0;

Console.WriteLine("Введите число для проверки четности: ");

while(  !int.TryParse(Console.ReadLine(), out int_1 ))
{
    Console.Write("Введено некорректное число, повторите попытку ввода: ");
}

if( int_1 % 2 == 0) Console.WriteLine($"Чило {int_1} является четным.");
else Console.WriteLine($"Чило {int_1} является не четным.");
