// Найти произведение двух матриц


Console.WriteLine();
int[,] m1 =  {{1, 2, 3},
           {4, 5, 6},
           {7, 8, 9}};



int[,] m2 ={{0, 1, 2},
        {3, 4, 5},
        {6, 7, 8}};


int j;
for (int i = 0; i < 3; i++)
{
  for (j = 0; j < 3; j++)
  {
    m1[i, j] = m1[i, j] * m2[i, j];
    Console.Write(m1[i, j]);
    Console.WriteLine("\n");
  }
  j = 0;
}
Console.WriteLine();







