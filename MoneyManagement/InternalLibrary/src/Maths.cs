using System.Reflection;
using log4net;

namespace InternalLibrary;

public class Maths
{
    #region Debug / Log

    private static readonly ILog Log =
        LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);

    #endregion
    
    #region External Constructor

    public Cash Cash { get; set; } = new ();
    private Bills Bills { get; set; }= new ();
    public DaySpending DaySpending { get; set; }= new ();
    public MoneyAllowance MoneyAllowance { get; set; }= new ();
    
    #endregion

    public double Balance { get; set; } = 1300;
    private double TotalBills { get; set; }    

    public void Initalise()
    {
        // if Day spending updates then total bill is updated
        TotalBills = Bills.TotalBill + DaySpending.TotalAmountSpentToday;
        // Cash after bills deducted
        Cash.AfterBillsCalculation(Balance, TotalBills);

        // Amount to save
        MoneyAllowance.CalculateAmountToSave(Cash.NewBalance, 20);
    }
    
    public void ResetDaySpent()
    {
        var time = DateTime.Parse("23:59");
        if (DateTime.Now.Hour >= time.Hour)
        {
            DaySpending.ListOfDaySpending.Clear();
            
        }
        Log.Debug($"{DateTime.Now}");
        
        
        
    }
    
}