// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
double result = 1;
for (int i = 1; i <= result; i++ ) 
{
   result = Math.Pow(numberA, numberB);
}
Console.WriteLine(result);
