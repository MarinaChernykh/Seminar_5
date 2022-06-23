// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] NewArray = CreateFillArray();
PrintArray (NewArray);
Sum (NewArray);

int [] CreateFillArray ()
{
    Console.Write ("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100,101);
    }
    return arr;
}

void PrintArray (int [] arr)
{
    for (int i = 0; i <arr.Length; i++)
    {
        Console.Write ($"{arr [i]} ");
    }
    Console.WriteLine();
}

void Sum (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        sum +=arr[i];
    }
    Console.WriteLine ($"Сумма = {sum}");
}
