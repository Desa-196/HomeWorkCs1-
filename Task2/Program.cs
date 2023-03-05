Console.WriteLine("Нахождение максимального из трех чисел");

//Достаточно изменить размерность массива, и можно вводить сколько угодно чисел для поиска максимума
int[] int_array = new int[3];
int max = 0;

for(int i=0; i < int_array.Length; i++)
{
    Console.Write($"Введите {i+1}-ое число: ");

    //TryParse то-же что и Parse, но не возникает исключение при строке не содержащей цифры, а возвращает 0, вторым параметром передаем ссылку для возврата результата. 
    while(  !int.TryParse(Console.ReadLine(), out int_array[i] ))
    {
        Console.Write($"Введено некорректное число, повторите попытку ввода {i+1}-го числа:");
    }

}

max = int_array[0];

for(int i=1; i < int_array.Length; i++)
{
    if(max < int_array[i]) max = int_array[i];
}
Console.WriteLine($"Максимальное число из введенных: {max}");