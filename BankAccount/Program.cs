/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Банковский Счет».
В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету,
сумма счета. В теле метода создайте следующие методы: Метод, который рассчитывает
количество дней, начиная с даты открытия счета; Метод который выводит информацию о
количестве рассчитанных дней; Метод который рассчитывает сумму, которая будет на счете
через определенное количество лет (количество лет – параметр метода); Метод который
выводит информацию о сумме. Также продумать над конструктором класса. В методе Main()
создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства
доступа, а также на экземпляр класса вызовите методы для отображения количества дней и
суммы.
*/

DateTime openingDate = new(2022, 9, 13);

float yearRate = 15;
int currentMoney = 1000;
int years = 5;

BankAccount bankAccount = new(openingDate, yearRate, currentMoney);

bankAccount.ShowDaysInfo();
bankAccount.MoneyAmount(years);

Console.ReadKey();
public class BankAccount
{
    public DateTime OpeningDate { get; set; }
    public float YearRate { get; set; }
    public int CurrentMoney { get; set; }
    public BankAccount(DateTime openingDate, float yearRate, int currentMoney)
    {
        OpeningDate = openingDate;
        YearRate = yearRate;
        CurrentMoney = currentMoney;
    }
    public int DaysFromOpen()
    {
        DateTime dateNow = DateTime.Now;
        int days = (int)(dateNow - OpeningDate).TotalDays;
        return days;
    }
    public void ShowDaysInfo()
    {
        Console.WriteLine($"Количество дней с открытия счёта - {DaysFromOpen()}");
    }
    public void MoneyAmount(int years)
    {
        float totalMoney = CurrentMoney * YearRate / 100 + CurrentMoney;

        for (int i = 1; i < years; i++)
        {
            totalMoney += (float)(totalMoney * YearRate / 100);
        }
        Console.WriteLine($"Общая сумма счёта через {years} лет - {totalMoney} грн.");
    }
}

