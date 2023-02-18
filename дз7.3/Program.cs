// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine();
int[,] matrix = {{6,4,4,6},
                       {2,8,8,7},
                       {7,4,8,5},
                       {2,1,1,8}};


int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < 4; i++)
{
  int temp = 0;
  for (int j = 0; j < 4; j++)
  {
    temp += matrix[i, j];
  }
  if (temp < sum)
  {
    sum = temp;
    index = i;
  }
}
Console.WriteLine("Строка с наименьшей суммой элементов: "+index+ "");
Console.WriteLine("Сумма элементов = "+sum);
Console.WriteLine();
for (int i = 0; i < 4; i++)
{
  Console.Write(matrix[index, i] + " ");
}
Console.WriteLine();
