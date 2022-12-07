// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        if (i % 2 != 0)
        {
            buff += nArr[i];
        }
    }

    Console.WriteLine($"Сумма элементов массива [{string.Join("; ", nArr)}] стоящих на нечетных позициях равна: {buff}");
}

int quantityElements = initialData("Введите число элементов массива: ");

int bottomBorder = initialData("Введите нижнюю границу значений массива: ");

int upperBorder = initialData("Введите верхнюю границу значений массива: ");

int[] newArray = new int[quantityElements];

newArray = CreateSomeArray(quantityElements, bottomBorder, upperBorder);

WriteSumHonestValuesArray(newArray);