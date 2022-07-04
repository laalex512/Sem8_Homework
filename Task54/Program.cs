/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

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
int temp;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < numbers.GetLength(1) - 1 - j; k++)
        {
            if (numbers[i, k] < numbers[i, k + 1])
            {
                temp = numbers[i, k + 1];
                numbers[i, k + 1] = numbers[i, k];
                numbers[i, k] = temp;
            }
        }
    }
}

PrintArray2Lines(numbers);