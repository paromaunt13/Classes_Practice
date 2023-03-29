/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Котенок».
В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. Для каждого
поля, создать свойство с двумя методами доступа. Также в теле класса создайте метод,
который будет выводить на консоль «Мяу», метод должен принимать один аргумент –
количество «Мяу» котенка, выводить «Мяу» соответствующее количество раз. В методе Main()
создайте экземпляр класса «Котенок», присвойте всем полям значение через свойства доступа, а
также вызовите метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода
передайте 3.
*/

Kitten kitten = new()
{
    Name = "Барсик",
    Age = 3,
    FurColor = "Серый",
    EyeColor = "Голубой"
};

kitten.SayMeow(3);
Console.ReadKey();

public class Kitten
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string FurColor { get; set; }
    public string EyeColor { get; set; }

    public void SayMeow(int meowCount)
    {
        string meow = "Мяу!";
        while (meowCount > 0)
        {
            Console.WriteLine(meow);
            meowCount--;
        }
    }
}