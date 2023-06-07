void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

int CountNumbers(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element > 0)
        count++;
    }
    return count++;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Кол-во положительных элементов: {CountNumbers(array)}");