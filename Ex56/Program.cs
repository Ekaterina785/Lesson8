int w = 0;
int q = 0;
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки = {sum}");
    if (i == 0)
    {
        q = sum;
    }
    else 
    {
        if(sum < q)
        {
            q = sum;
        }
    }
}

int d =0;
for (int j = 0; j < array.GetLength(1); j++)
{
    d += array[w, j];
}
Console.WriteLine($"Строка с минимальной суммой элементов равна {d} "); 

