﻿/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три
закрытых поля для описания сторон треугольника и три свойства для чтения и записи. Также в
теле класса создайте 3 метода: 1-й для расчета площади треугольника, формула для расчета S =
√p ∗ (p − a) ∗ (p − b) ∗ (p − c), где p - полупериметр треугольника p = (a + b + c)/2, a, b, c –
длины сторон треугольника, 2-й для расчета периметра треугольника, формула для расчета p =
(a + b + c)/2 и 3-й для вывода информации о площади и периметре треугольника. Создайте
конструктор, который в качестве аргументов приминимает стороны треугольника и
инициализирует поля класса. В методе Main() создайте экземпляр класса «Треугольник», задайте
произвольное значение сторон треугольника и выведите на экран значение периметра и
площади треугольника.
*/

Triangle triangle = new(50, 25, 30);
triangle.ShowTriangleInfo();

Console.ReadKey();
public class Triangle
{
    public int SideA { get; set; }
    public int SideB { get; set; }
    public int SideC { get; set; }
    public Triangle(int a, int b, int c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }
    private float TrianglePerimetr()
    {
        float perimetr = (SideA + SideB + SideC) / 2;
        return perimetr;
    }
    private float TriangleArea()
    {
        float p = TrianglePerimetr();
        float s = MathF.Sqrt(p * ((p - SideA) * (p - SideB) * (p - SideC)));
        return s;
    }
    public void ShowTriangleInfo()
    {
        Console.WriteLine($"Площадь треугольника - {TriangleArea()}");
        Console.WriteLine($"Периметр треугольника - {TrianglePerimetr()}");
    }
}
