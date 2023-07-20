// ДЗ Задача 2 найти максимальное число из 2-х введеных

Console.Write("Введите число A: ");
string userInput = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput);

Console.Write("Введите число Б: ");
string userInput1 = Console.ReadLine() ?? "";
int num2 = int.Parse(userInput1);

if (num1 > num2)
{
    Console.Write($" max= {num1}");
}
else
{
    Console.Write($" max= {num2}");
}
