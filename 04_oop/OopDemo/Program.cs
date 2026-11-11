interface ISpeaker
{
    string Speak();
}

class Dog : ISpeaker
{
    public string Speak() => "Woof!";
}

class Cat : ISpeaker
{
    public string Speak() => "Meow!";
}

class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount));
        Balance += amount;
    }
}

record Person(string Name, int Age);

Console.WriteLine(new Dog().Speak());
Console.WriteLine(new Cat().Speak());
var account = new BankAccount();
account.Deposit(50m);
Console.WriteLine($"Balance: {account.Balance:C}");
Console.WriteLine(new Person("Ada", 28));
