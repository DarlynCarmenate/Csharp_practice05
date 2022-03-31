// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] RandArray (int length)
{
	double[] answer = new double[length];
	for(int i = 0; i < length; i++)
	{
		Random rand = new Random();
		answer[i] = rand.NextDouble() * 100;
	}
	return answer;
}

void PrintArray(double[] Mas)
{
	int count = Mas.Length;
	Console.Write("[");
	for(int pos = 0; pos < count-1; pos++)
	{
		Console.Write($"{Mas[pos]:0.00}, ");
	}
	Console.WriteLine($"{Mas[Mas.Length-1]:0.00}]");
}

double MinMax(double[] arr)
{
	int i = 0;
	double min = arr[i];
	double max = arr[i];
	for(i = 0; i < arr.Length; i++)
	{
		if(arr[i] < min) 
		{
			min = arr[i];
		}
		if(arr[i] > max)
		{
			max = arr[i];
		}
	}
	Console.WriteLine($"Наименьшее число: {min:0.00}");
	Console.WriteLine($"Наибольшее число: {max:0.00}");
	double result = max - min;
	return result;
}

double[] arr = RandArray(10);
PrintArray(arr);
Console.WriteLine($"Разница между наибольшим и наименьшим числом: {MinMax(arr):0.00}");