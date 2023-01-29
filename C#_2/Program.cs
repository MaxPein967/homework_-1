// Задача2: Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньшее.
// a = 5 b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA != numberB)
{
    if (numberA > numberB)
    {
        Console.WriteLine($"Максимальное: {numberA}");
    }
    else
        Console.WriteLine($"Максимальное: {numberB}"); 
}
    
else
    Console.WriteLine($"Они равны");