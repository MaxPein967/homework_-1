// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int i;
Console.Write("введите число: ");
i = Console.Read();
if (i % 2 == 0)
{
    Console.Write(" да ");
}
else
{
    Console.Write(" нет ");
}