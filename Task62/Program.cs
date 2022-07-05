/*Задача 62: Заполните спирально массив 4 на 4.*/

void PrintArray2Lines(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            if(arrayForPrint[i,j]<10)
            {
                string oneDigitNuber = "0"+Convert.ToString(arrayForPrint[i,j]);
                Console.Write(oneDigitNuber+"  ");
            }
            else
                Console.Write(arrayForPrint[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int arraySize = InputInt("size of array");
int[,] spiralArray = new int[arraySize, arraySize];

int currentRow = 0;
int currentColumn = 0;
int maxIndex = spiralArray.GetLength(0) - 1;
int minIndex = 0;
int currentValue = 1;

while (currentValue <= spiralArray.Length)
{
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (currentValue == spiralArray.Length+1)
            break;
        spiralArray[minIndex, i] = currentValue;
        currentValue++;
    }
    for (int i = minIndex + 1; i <= maxIndex; i++)
    {
        if (currentValue == spiralArray.Length+1)
            break;
        spiralArray[i, maxIndex] = currentValue;
        currentValue++;
    }
    for (int i = maxIndex - 1; i >= minIndex; i--)
    {
        if (currentValue == spiralArray.Length+1)
            break;
        spiralArray[maxIndex, i] = currentValue;
        currentValue++;
    }
    for (int i = maxIndex - 1; i > minIndex; i--)
    {
        if (currentValue == spiralArray.Length+1)
            break;
        spiralArray[i, minIndex] = currentValue;
        currentValue++;
    }
    maxIndex--;
    minIndex++;
}
PrintArray2Lines(spiralArray);