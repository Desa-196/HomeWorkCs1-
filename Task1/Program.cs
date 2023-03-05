Console.WriteLine("Нахождение максимального из двух чисел");

int int_1 = 0;
int int_2 = 0;

Console.Write("Введите первое число: ");

//TryParse то-же что и Parse, но не возникает исключение при строке не содержащей цифры, а возвращает 0, вторым параметром передаем ссылку для возврата результата. 
while(  !int.TryParse(Console.ReadLine(), out int_1 ))
{
    Console.Write("Введено некорректное число, повторите попытку ввода первого числа:");
}

Console.Write("Введите второе число: ");

while(  !int.TryParse(Console.ReadLine(), out int_2 ))
{
    Console.Write("Введено некорректное число, повторите попытку ввода второго числа:");
}

//Если попали сюда, значит все ок с вводом, продолжаем.
if(int_1 > int_2)       Console.WriteLine($"Первое число ({int_1}) больше второго ({int_2})");
else if(int_2 > int_1)  Console.WriteLine($"Второе число ({int_2}) больше первого ({int_1})");
else                    Console.WriteLine($"Введенные числа равны");