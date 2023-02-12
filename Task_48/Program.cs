// Задайте двумерный массив. Размер m и n, каждый элемент в массиве находится по формуле: Amn = m+n.
// выведите полученный массив на экран: m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5




int[,] arr = new int[3,4];
Random rnd = new Random();

System.Console.WriteLine(arr.Length);

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i,j] = rnd.Next(100);  
    }
}


for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i,j] + " ");
    }
    System.Console.WriteLine();
}
