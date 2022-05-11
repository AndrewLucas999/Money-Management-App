namespace InternalLibrary;

public class Cash
{
    public double NewBalance { get; set; }
    public void AfterBillsCalculation(double balance, double bills)
    {
        var balanceAfterBills = balance - bills;
        NewBalance = balanceAfterBills; 
    }   
}