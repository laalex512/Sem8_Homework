/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/


 int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2Lines(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write(arrayForPrint[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArr2LinesRandom(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(0, 10);
        }
    }
}



int m = InputInt("m");
int n = InputInt("n");
int[,] numbers = new int[m, n];

FillArr2LinesRandom(numbers);
PrintArray2Lines(numbers);

int[] arrayRowSums = new int[numbers.GetLength(0)];

for (int i=0; i <numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        arrayRowSums[i] += numbers[i,j];
    }
    Console.WriteLine(arrayRowSums[i]);
}

int indexMin = 0;
for (int i = 1; i < arrayRowSums.Length; i++)
{
    if (arrayRowSums[i]<arrayRowSums[indexMin])
        indexMin = i;
}

Console.WriteLine("Row with min sum - "+indexMin);
