// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[5];
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(-100, 101);
            Console.Write($"{numbers[i]}, ");
        }
        int sum = 0;
        for (int i = 1; i < numbers.Length; i += 2)
        {
            sum += numbers[i];
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
    }
}