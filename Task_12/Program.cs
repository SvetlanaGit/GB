// Напишите программу, которая будет принимать на вход два числа, и выводить является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 --> не кратно
// 16, 4 --> кратно.


double newNumber()
{
    System.Console.WriteLine("--> ");
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
// double first=newNumber();
// double second=newNumber();

// if (first%second==0){
//     System.Console.WriteLine(first + "кратно" + second);
// }
// else 
// System.Console.WriteLine("Некратно, остаток: " + (first%second));
double num = newNumber();
if  ((num%7==0) && (num%23==0)) {
    System.Console.WriteLine(num + "кратно 7 и 23");
}
else
{
    System.Console.WriteLine(num + "некратно");
}


