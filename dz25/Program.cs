// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] myArray = new int[8];

for (int i = 0; i < myArray.Length; i++)
{
    System.Console.WriteLine($"Введите элемент массива под индексом {i} ");
    myArray[i] = int.Parse(Console.ReadLine() ?? "");
}

System.Console.WriteLine("Вывод массива: ");

for (int i = 0 ; i < myArray.Length; i++)
{
    System.Console.Write(" " + myArray[i]);
}

Console.ReadLine();