// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

int[] NewArray = CreateFillArray();
PrintArray(NewArray);
CheckArray(NewArray);

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

void CheckArray(int[] array)
{
    Console.Write("Введите число, которое нужно найти: ");
    int number = Convert.ToInt32(Console.ReadLine());
    bool check = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"Число {number} есть в массиве");
            check = true;
            break;
        }
    }
    if (check == false) Console.WriteLine($"Числа {number} нет в массиве");
}

