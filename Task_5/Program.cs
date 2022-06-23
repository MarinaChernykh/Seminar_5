// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] ArrayOne = CreateFillArray();
PrintArray(ArrayOne);
int[] ArrayTwo = UpdateArray(ArrayOne);
PrintArray(ArrayTwo);

int[] CreateFillArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
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

int[] UpdateArray(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int size = array.Length / 2;
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        return result;
    }

    else
    {
        int size = array.Length / 2 + 1;
        int[] result = new int[size];
        for (int i = 0; i < size - 1; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        result[size - 1] = array[size - 1];
        return result;
    }
}
