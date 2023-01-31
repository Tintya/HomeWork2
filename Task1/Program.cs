/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int GetNewNumber(int number)
{
    int result = number % 100 / 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);

int result = GetNewNumber(number);
Console.WriteLine($"второе число {result}");