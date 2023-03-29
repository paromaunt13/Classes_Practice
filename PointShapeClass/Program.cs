/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс «Точка» – для описания координат точки на
координатной прямой рис No1. В теле класса создайте следующие закрытые поля: целочисленное
поле для описания координаты точки X и целочисленное поле для описания координаты точки
Y, а также строковое поле для имени точки. Создать три свойства с методами доступа get и
set, а также конструктор класса, который будет инициализировать данные поля значениями
аргументов. Далее создайте класс «Фигура». В теле класса фигура создайте одно поле типа масив
«Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3
(треугольника) и 4 аргумента (четырехугольника). В теле класса «Фигура» создайте два метода: 1-
й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» и
возвращать длину стороны, формула для расчета d = √(x2 − x1)2 + (y2 − y1)2 и метод для
расчета периметра фигуры (подсказка – в методе циклом перебирать массив «Точек», пока в нем
будут элементы, и рассчитывать длину стороны). В методе Main() создать и рассчитать периметр
треугольника, квадрата, прямоугольника, точки выбрать произвольные.
*/

Point p1 = new(2, 2, "1");
Point p2 = new(2, -2, "2");
Point p3 = new(-2, -2, "3");
Point p4 = new(-2, 2, "4");

Figure triangle = new(p1, p2, p3);
triangle.Perimetr(triangle);

Figure rectangle = new(p1, p2, p3, p4);
rectangle.Perimetr(rectangle);

Figure square = new(p1, p2, p3, p4);
square.Perimetr(square);

Console.ReadKey();
public class Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }
    public Point(int x, int y, string name)
    {
        X = x;
        Y = y; 
        Name = name;
    }
}
public class Figure
{
    private Point[] points;
    private string name;
    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
        name = "Треугольник";
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
        name = "Прямоугольник/квадрат";
    }
    public int FigureSide(Point p1, Point p2)
    {
        int d = (int)Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        return d;
    }
    public void Perimetr(Figure figure)
    {
        int perimetr = 0;     
        for (int i = 0, j = 1; i < points.Length && j < points.Length; i++, j++)
        {            
            perimetr += FigureSide(figure.points[i], figure.points[j]);
            if (j == points.Length - 1)
            {
                i = 0;
                perimetr += FigureSide(figure.points[i], figure.points[j]);
            }
        }
        if (figure.points.Length == 3)
            Console.WriteLine($"Фигура: {figure.name} \nПериметр равен {perimetr}");
        if (figure.points.Length == 4)
            Console.WriteLine($"Фигура: {figure.name} \nПериметр равен {perimetr}");
    }
}
