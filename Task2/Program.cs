/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/

Console.Clear();

double PromptCoefficient(string coeff)
{
    Console.Write($"Введите коэффициент {coeff}: ");
    double coefficient = Convert.ToDouble(Console.ReadLine());
    return coefficient;
}

void FindLinesIntersection (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1*x + b1;
     
    Console.WriteLine($"Координаты точки пересечения двух линий ({x}; {y})"); 
}

FindLinesIntersection(PromptCoefficient("b1"), PromptCoefficient("k1"),
PromptCoefficient("b2"), PromptCoefficient("k2")); 