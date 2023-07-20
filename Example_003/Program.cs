Console.Write("Введите число A: ");
string userInput = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput);

Console.Write("Введите число Б: ");
string userInput1 = Console.ReadLine() ?? "";
int num2 = int.Parse(userInput1);

int result = num1/num2;

if (num1 == result)
{
Console.Write($"{result} А является квадратом числа Б ");
}
else
{
    Console.Write($"{result} А НЕ является квадратом числа Б ");
}
