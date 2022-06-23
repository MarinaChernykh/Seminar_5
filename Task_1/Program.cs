// Задайте массив из 12 элементов, заполненный cлучайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных 
// и положительных элементов массива.

int[] NewArray = new int[12];
FillArray(NewArray);
PrintArray(NewArray);
Sum(NewArray);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Sum(int[] array)
{
    int SumPositive = 0;
    int SumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) SumPositive += array[i];
        else SumNegative += array[i];
    }
    Console.WriteLine ($"Сумма положительных чисел = {SumPositive}");
    Console.WriteLine ($"Сумма отрицательных чисел  = {SumNegative}");
}