// ДЗ Задача №4 найти максимальное число из 3-х
Console.Write("Введите число A: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);

Console.Write("Введите число B: ");
string userInput2 = Console.ReadLine() ?? "";
int num2 = int.Parse(userInput2);

Console.Write("Введите число C: ");
string userInput3 = Console.ReadLine() ?? "";
int num3 = int.Parse(userInput3);

int max = num1; //Присваиваем max число А

if (max > num2) //Сравниваем A c B
{
    if (max > num3) //Сравниваем А с С
    {
        Console.Write($" max= {max}");
    }
    else
    {
        max = num3; //Если С больше А мах = С
    }
}
else if (num2 > num3)
{
    Console.Write($" max= {num2}"); //Выводим ммаксимальное число
}
else
{
    Console.Write($" max= {num3}"); //Выводим ммаксимальное число
}
