// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] --> [54321]
// [6 7 3 6] --> [6376]




Console.WriteLine("Введите размер массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int [len];
Random rnd = new Random();


FillRandomArray (array, len);
PrintArray (array, len);
ReversArray (array, len);
PrintArray (array, len);


void ReversArray(int[] array, int length)
{
    int temp;
    for (int i=0; i<length/2; i++)
    {
        temp=array[i];
        array[i]=array[length-1-i];
        array[length-1-i]=temp;
    } 
}

void FillRandomArray(int[] array, int length)
{
    for (int i=0; i<length; i++)
    {
        array[i] = rnd.Next(100);
    }
}


void PrintArray(int[] array, int length)
{
    Console.Write("--> ");
    for (int i=0; i<length; i++)
    {
        if (i<length-1)
        Console.Write($"{array[i]},");
        else
        Console.WriteLine($"{array[i]}");
    }
}
