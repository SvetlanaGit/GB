// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1.
// Если N = 5 --> 0 1 1 2 3
// Если N = 3 --> 0 1 1 
// Если N = 7 --> 0 1 1 2 3 5 8


int InputNumber()
{
    Console.WriteLine("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int n = InputNumber();
int a = 0;
int b = 1;
int temp = 0;

for (int i = 0; i < n; i++)
{
    Console.WriteLine(a);

    temp = a;
    a=b;
    b=a+temp;
}