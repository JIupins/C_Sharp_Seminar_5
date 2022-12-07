/* Задайте массив заполненный случайными положительными трёхзначными числами. 
 Напишите программу, которая покажет количество чётных чисел в массиве */

Console.Clear();

int initialData(string phrase)
{
    Console.Write(phrase);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] CreateSomeArray(int qtyElem, int botBord, int uppBord)
{
    int[] Ary = new int[qtyElem];

    for (int i = 0; i < Ary.Length; i++)
    {
        Ary[i] = new Random().Next(botBord, uppBord + 1);
    }

    return Ary;
}

void WriteSumHonestValuesArray(int[] nArr)
{
    int buff = default;

    for (int i = 0; i < nArr.Length; i++)
    {
        if (nArr[i] % 2 == 0)
        {
            buff += nArr[i];
        }
    }

    Console.WriteLine($"Количество четных элементов в массиве [{string.Join("; ", nArr)}] равно: {buff}");
}

int quantityElements = initialData("Введите число элементов массива: ");

int bottomBorder = initialData("Введите нижнюю границу значений массива: ");

int upperBorder = initialData("Введите верхнюю границу значений массива: ");

int[] newArray = new int[quantityElements];

newArray = CreateSomeArray(quantityElements, bottomBorder, upperBorder);

WriteSumHonestValuesArray(newArray);