// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[] array = new double[size];

double minNum = max;
double maxNum = min;


ArrayRandomNum(array);
FindMinAndMax(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();



Console.WriteLine($"Минимальное значение в массиве {minNum}");
Console.WriteLine();
Console.WriteLine($"Максимальное значение в массиве {maxNum}");
Console.WriteLine();


double diff = maxNum - minNum;

Console.WriteLine($"Разница между максимальным и минимальным значением = {diff}");
Console.WriteLine();




void ArrayRandomNum(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(min,max)) / 100;
    }
}


void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

void FindMinAndMax(double[] array)
{
    for (int k = 0; k < array.Length; k++)
{
    if(array[k]< minNum)
        minNum = array[k];
    else if(array[k]> maxNum)
        maxNum = array[k];
}
}


