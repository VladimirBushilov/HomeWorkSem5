// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = { 1.2, 2.7, -12.3, 34, 5.2, -13.5 };
double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
}

double diff = max - min;

Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами: {diff}");