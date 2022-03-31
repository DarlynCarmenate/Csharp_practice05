// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandArray (int length)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(1, 50);
	}
	return answer;
}

void PrintArray(int[] Mas)
{
	int count = Mas.Length;
	for(int pos = 0; pos < count; pos++)
	{
		Console.Write(Mas[pos] + ",");
	}
}

int[] arr = RandArray(20);
PrintArray(arr);
int count = 0;
Console.WriteLine();
Console.WriteLine("Числа на нечетных позициях: ");

for(int i = 0; i < arr.Length; i = i + 2)
{
    Console.Write(arr[i] + ",");
}


