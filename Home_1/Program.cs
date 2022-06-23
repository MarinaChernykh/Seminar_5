// Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.

int [] NewArray = CreateFillArray();
PrintArray (NewArray);
CountEvenInt (NewArray);


int [] CreateFillArray ()
{
    Console.Write ("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100,1000);
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

void CountEvenInt (int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 ==0) count +=1;
    }
    Console.WriteLine ($"Кол-во четных чисел в массиве = {count}");
}
