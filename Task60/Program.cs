/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}



int rowArray = InputInt("rows array");
int columnArray = InputInt("columns array");
int floorArray = InputInt("floors array");
int[,,] arrayThreeLinesRndNums = new int[rowArray, columnArray, floorArray];

int[] arrayParticipationNums = new int[90];                              // массив использованных чисел
int currentIndexParticipation = 0;

if (rowArray * columnArray * floorArray <= 90)
{
    for (int i = 0; i < arrayThreeLinesRndNums.GetLength(0); i++)
    {
        for (int j = 0; j < arrayThreeLinesRndNums.GetLength(1); j++)
        {
            for (int k = 0; k < arrayThreeLinesRndNums.GetLength(2); k++)
            {
                while (true)
                {
                    int tempNumber = new Random().Next(10, 100);
                    bool canUseNumber = true;
                    for (int l = 0; l < currentIndexParticipation; l++)
                    {
                        if (tempNumber == arrayParticipationNums[l])
                            canUseNumber = false;
                    }
                    if (canUseNumber)
                    {
                        arrayThreeLinesRndNums[i, j, k] = tempNumber;
                        arrayParticipationNums[currentIndexParticipation] = tempNumber;
                        currentIndexParticipation++;
                        break;
                    }
                }
                Console.WriteLine($"{arrayThreeLinesRndNums[i, j, k]} - [{i},{j},{k}]");
            }
        }
    }
}
else
{
    Console.WriteLine("Array is too big");
}