// ДЗ Задача №8 ввести все четные числа от 1 до N
Console.Write("Введите число: ");
string userInput1 = Console.ReadLine() ?? "";
int num1 = int.Parse(userInput1);

int i = 2; //счетчик 

while (i <= num1)
{
    if (i % 2 == 0) //проверка на четность
    {
        Console.Write($"{i}, ");
    }
   
    i = i + 2;
}
