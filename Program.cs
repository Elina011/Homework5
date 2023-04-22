// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int DifMaxMin(int[] massive)
{
int max = massive[0];
int min = massive[0];
    for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] > max)
    max = massive[i];
    if (massive[i]<min)
    min = massive[i];
}
        return max-min;
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
Console.WriteLine(DifMaxMin(massive));