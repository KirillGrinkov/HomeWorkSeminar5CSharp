// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Какое количество чисел вы понируете ввести? Введите ответ: ");
int num = Convert.ToInt32(Console.ReadLine());

int[]Array = new int[num];

FillArray(num);
Console.Write($"\n Чисел больше нуля: {Amount(Array)}   ");



void FillArray(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int Amount(int[]Array)
{
    int i = 0;
    int count = 0;
    while (i < Array.Length)
    {
        if(Array[i]>0) count++; i++;
    }
    return count;
}


