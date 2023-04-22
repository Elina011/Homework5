// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int SumOdd(int[] massive)
{
int sum = 0;
    for (int i = 0; i < massive.Length; i++)
    {
       sum = sum + massive[i];
       i = i+1;
    }
    return sum;
}

int[] MakeRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue,maxValue+1);
    }
    return massive;
}

int[] massive = MakeRandomArray(5, 100, 999);
Console.Write($"{String.Join(", ", massive)} ->");
Console.WriteLine(SumOdd(massive));