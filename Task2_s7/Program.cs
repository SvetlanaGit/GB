// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите количество строк: --> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: --> ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int [m,n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i,j] = new Random().Next(10);
        Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();


int sum = 0;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j);
        {
            sum = sum + array [i,j];
        }
    }

}
System.Console.WriteLine(sum);