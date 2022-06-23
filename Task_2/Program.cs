// Напишите программу замены элементов массива: 
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

int[] CreateFillArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ConvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= (-1);
    }
}

int[] NewArray = CreateFillArray();
PrintArray(NewArray);
ConvertArray(NewArray);
PrintArray(NewArray);
