// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int count = 1;
int max = 0;
while (count < 4)
{
    Console.Write("Введите число " + count + "= ");
    int number = int.Parse(Console.ReadLine());
    if (number > max)
    {
        max = number;
        count++;
    }
    else
    {
        count++;
    }
}
Console.Write("Максимальное число равно: " + max);
