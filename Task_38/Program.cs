// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] InitializingArray(string phrase)
{
    Console.Write(phrase);
    int quantityOfElements = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[quantityOfElements];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }

    Console.WriteLine($"Создан массив элементов: [{string.Join("; ", array)}]");
    return array;
}

void FindDiffBetweenMinMax(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++) if (max < arr[i]) max = arr[i];

    for (int i = 0; i < arr.Length; i++) if (min > arr[i]) min = arr[i];

    Console.Write($"Разница между максимальным значением массива {max} и его минимальным значением {min} равна: {(max - min):0.00}");
}

double[] newArray = InitializingArray("Введите число элементов массива: ");

FindDiffBetweenMinMax(newArray);