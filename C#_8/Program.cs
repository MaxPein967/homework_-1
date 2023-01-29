// Задача 8: Напишите программу, которая на вход принимает число (N), на выходе показывает все четные числа от еденицы до N.
// 5 -> 2, 4
// 8 -> 2,4,6,8

int numberM = 1;
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
for (int i = numberM; i <= numberN; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
}
