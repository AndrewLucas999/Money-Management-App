namespace InternalLibrary;

public class Maths
{
    public float Balance { get; set; }
    public float CreditBalance;

    public float Rent = 565;
    public Maths()
    {
        Initalise();
    }

    public void Initalise()
    {
        AfterBills();
    }
    public void CalculateBalance()
    {
        
    }

    public void AfterBills()
    {
        var balance = 1000;
        var balanceAfterBills = balance - Rent;
        Balance = balanceAfterBills;
    }
}