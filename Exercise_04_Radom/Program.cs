// Сгенерируем 2 случайные целые число, выводим результат их сложение.
int a = new Random().Next(1,20); // 1,2,3,4...18,19
Console.WriteLine("Генерируем первое число a= " + a);
int b = new Random().Next(1,10);
Console.WriteLine("Генерируем второе число b= " + b);
Console.Write("The result is- a:b= " + a/b);