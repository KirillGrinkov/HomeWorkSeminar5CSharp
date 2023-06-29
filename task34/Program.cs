//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];


int count = 0;


ArrayRandomNum(array);
DivideTwo(array);
PrintArray(array);



Console.Write($"  четных чисел {count}");



void ArrayRandomNum(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}



 void DivideTwo(int[] array)
 {
    for (int j = 0; j < array.Length; j++)
        if (array[j] % 2 == 0)
            count++;
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
