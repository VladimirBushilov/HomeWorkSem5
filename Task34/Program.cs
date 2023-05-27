// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2*/

// Console.WriteLine("Введите размер массива ");

// int size = int.Parse(Console.ReadLine());

// int[] num = new int[size];

// Random rand = new Random();

// for (int i = 0; i < num.Length; i++)
// {
//     num[i] = rand.Next(100, 1000);
//     Console.WriteLine(num[i]);
// }

// int Count = 0;
// foreach (int number in num)
// {
// if (number % 2 == 0)

// {
//  Count ++; 
// }

// }
// Console.WriteLine($"всего {num.Length} чисел, {Count} из них чётные");




Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int Count = 0;

for (int a = 0; a < numbers.Length; a++)
    if (numbers[a] % 2 == 0)
        Count++;

Console.WriteLine($"всего {numbers.Length} чисел, {Count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}