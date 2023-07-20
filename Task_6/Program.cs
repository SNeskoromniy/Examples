// ДЗ Задача №6 ввести число и проверить на четность
Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);
//int result = num1 % 2;

if (num1 % 2 == 0) //проверка деления числа на 2 без остатка
{
    Console.Write("Число чётное");
}

else
{
   Console.Write("Число не чётное");
}
