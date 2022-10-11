/* Написать программу в С#,который в входе получет от пользователя 2 целые числа, 
а на выходе сложит их и покажет результат на экране. */
Console.WriteLine("Enter the first number a= ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the second number b= ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("The summa of two numbers a + b = ");
Console.Write(a+b);
