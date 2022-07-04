/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.*/


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

int rowArrayA = InputInt("rows matrix A");
int columnArrayA = InputInt("columns matrix A");
int rowArrayB = InputInt("rows matrix B");
int columnArrayB = InputInt("columns matrix B");

int[,] arrayA = new int[rowArrayA, columnArrayA];
int[,] arrayB = new int[rowArrayB, columnArrayB];

FillArr2LinesRandom(arrayA);
FillArr2LinesRandom(arrayB);
PrintArray2Lines(arrayA);
PrintArray2Lines(arrayB);

int[,] arrayMultipleAB = new int[rowArrayA, columnArrayB];
for (int i = 0; i< arrayMultipleAB.GetLength(0); i++)
{
    for(int j = 0; j< arrayMultipleAB.GetLength(1); j++)
    {
        int temp =0;
        for (int k=0; k<arrayA.GetLength(1); k++)
        {
            temp+=arrayA[i,k]*arrayB[k,j];
        }
        arrayMultipleAB[i,j] = temp;
    }
}

PrintArray2Lines(arrayMultipleAB);

