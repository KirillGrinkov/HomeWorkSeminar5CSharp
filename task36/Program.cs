// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

ArrayRandomNum(array);
SumOdd(array);
PrintArray(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях  = {sum}");


void SumOdd(int[] array)
{
    for (int j = 1; j < array.Length; j= j + 2)
    sum = sum + array[j];
}


void ArrayRandomNum(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int k = 0; k < array.Length; k++)
    {
        Console.Write(array[k] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

