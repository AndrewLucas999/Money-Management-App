namespace InternalLibrary;

public class Maths
{
    #region External Constructor

    private Cash AfterBills = new ();
    private Bills Bills = new();

    #endregion

    public double Balance { get; set; } = 1300;
    
    public Maths()
    {
        Initalise();
    }

    public void Initalise()
    {
        AfterBills.AfterBillsCalculation(Balance, Bills.TotalBill);
        Balance = AfterBills.NewBalance;
    }
    

    
}