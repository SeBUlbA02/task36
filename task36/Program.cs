using static System.Console;//Нашёл в интернете как облегчить себе жизнь)
Clear();

Write("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

Write("Введите минимальное значение массива: ");
int min = int.Parse(ReadLine()!);

Write("Введите максимальное значение массива: ");
int max = int.Parse(ReadLine()!);

int[] Array = GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]"); 

FindOdd(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd= new Random();
    int[] result= new int[size];
    for(int i = 0; i< result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindOdd(int[] MyArray)
{
    int odd = 0;
    for (int i = 1; i < MyArray.Length; i = i + 2)
    {
        odd = odd + MyArray[i];
    }
    WriteLine($"Сумма чисел на нечётных позициях {odd}");
}

