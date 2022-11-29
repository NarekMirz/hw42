// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
System.Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine() ?? "");

int SumOfNum(int number)
{
    if(number < 10)
        return number;
    return number % 10 + SumOfNum(number/10);    
}
int result = SumOfNum(number);
System.Console.WriteLine($"Ваше число {number}, сумма цифр вашего числа --> {result}");
Console.ReadLine();