// Задача2: Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньшее.
// a = 5 b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA != numberB)
{
    if (numberA > numberB)
    {
        Console.Write($"a = {numberA}; b = {numberB} -> max = {numberA}");
    }
    else
        Console.Write($"a = {numberA}; b = {numberB} -> max = {numberB}");
}
    
else
    Console.WriteLine($"Они равны");