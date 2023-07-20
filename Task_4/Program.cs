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

if (max < num2) //Сравниваем A c B
{
    max = num2; //Если B больше А мах = B
}

if (max < num3) // Сравниваем мах с С 
{
    max = num3; //Если C больше мах то  мах = С
}

Console.Write($" max= {max}"); //Выводим ммаксимальное число
