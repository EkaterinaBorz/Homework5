// Составить частотный словарь элементов двумерного массива

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}
void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
int m = 3;
int n = 3;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();


int[,] dictionary = new int[m * n, 2];
int k = 0;

bool numb = false;

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    numb = false;
    for (int l = 0; l < k; l++)
    {
      if (dictionary[l, 0] == array[i, j])
      {
        dictionary[l, 1]++;
        numb = true;
        break;
      }
    }
    if (numb == false)
    {
      dictionary[k, 0] = array[i, j];
      dictionary[k, 1]++;
      k++;
    }
  }
}
for (int i = 0; i < k; i++)
{
  for (int j = 0; j < dictionary.GetLength(1); j++)
  {
    Console.Write($" {dictionary[i, +j]} ");
  }
  Console.WriteLine();
}