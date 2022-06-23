// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] NewArray = CreateFillArray();
PrintArray(NewArray);
Sum(NewArray);


double[] CreateFillArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        // генерирую рандомное вещественное число и для того, чтобы
        // оно не ограничивалось интервалом 0-1, домножаю его
        // на сгенерированное целое число (от -100 до 100):
        arr[i] = (new Random().NextDouble()) * (new Random().Next(-100,101));
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void Sum(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    res = max - min;
    Console.WriteLine($"Разница max-min = {res}");
}
