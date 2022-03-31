// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandArray (int length)
{
	int[] answer = new int[length];
	for(int i = 0; i < length; i++)
	{
		answer[i] = new Random().Next(0, 1000);
	}
	return answer;
}

void PrintArray(int[] Mas)
{
	Console.Write("[");
    int count = Mas.Length;
	for(int pos = 0; pos < count-1; pos++)
	{
		Console.Write(Mas[pos] + ",");
	}
    Console.Write(Mas[Mas.Length-1] + "]");
}

int[] arr = RandArray(10);
PrintArray(arr);
int count = 0;

for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 == 0) count++;
}

Console.WriteLine();
Console.WriteLine($"В данном массиве {count} четных чисел");