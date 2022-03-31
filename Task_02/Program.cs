// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandArray(int length)
{
    int[] answer = new int[length];
    for (int i = 0; i < length; i++)
    {
        answer[i] = new Random().Next(1, 50);
    }
    return answer;
}

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + ",");
    }
}

int Result(int[] array)
{
    int value = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        value = value + i;
    }
    return value;
}

int[] arr = RandArray(20);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях: {Result(arr)}");



