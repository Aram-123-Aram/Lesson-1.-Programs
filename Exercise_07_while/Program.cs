/* Увлекательная задача - путем розделение на 2 росстояние точек треугольника найти новые точки и 
повторяя циклично эти действие много раз- получить результат */
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");
int xa = 40, ya = 3,
    xb = 3, yb = 20,
    xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;
while(count < 10000)
{ int what = new Random().Next(0, 3); // [0,3)
if (what == 0) {x = (x + xa)/2; y = (y + ya)/2; }
if (what == 1) {x = (x + xb)/2; y = (y + yb)/2; } 
if (what == 2) {x = (x + xc)/2; y = (y + yc)/2; }
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count = count + 1;
}