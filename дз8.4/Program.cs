// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int[,,] array = new int[3, 3, 3];
FillArray(array);
PrintIndex(array);



void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int m = 0; m < array.GetLength(2); m++)
            {
                Console.Write($"{array[i, j, m]}({i},{j},{m}) ");
            }
        }
    }
}


void FillArray(int[,,] arr)
{
    int count = 20;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int m = 0; m < arr.GetLength(2); m++)
            {
                arr[m, i, j] += count;
                count += 4;
            }
        }
    }
}
