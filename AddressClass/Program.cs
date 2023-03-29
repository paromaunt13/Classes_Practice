/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Адрес».
В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо
создать метод для отображения информации про адрес. В методе Main() создайте экземпляр
класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр
класса вызовите метод, который выводит информацию про адрес.
*/


Address address = new()
{
    Country = "Украина",
    City = "Днепр",
    Street = "проспект Слобожанский",
    House = 1,
    Apartment = 10,
    Index = 49000
};

address.ShowAddressInfo();

Console.ReadKey();
public class Address
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int House { get; set; }
    public int Apartment { get; set; }
    public int Index { get; set; }

    public void ShowAddressInfo()
    {
        Console.WriteLine($"{Country}, город {City}, улица {Street}, дом {House}, квартира {Apartment}, {Index}");
    }
}

