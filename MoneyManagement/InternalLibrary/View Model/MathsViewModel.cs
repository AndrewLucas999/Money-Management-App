namespace InternalLibrary.View_Model;

public class MathsViewModel
{
    public Maths Maths { get; } = new ();
    public double DaySpending
    {
        get => Maths.DaySpending.TotalAmountSpentToday;
        set
        {
            Maths.DaySpending.TotalAmountSpentToday = value;  
        } 
    }

    public double Cash => Maths.Cash.NewBalance;
    public double AmountToSave => Maths.MoneyAllowance.AmountToSave;
    public MathsViewModel()
    {
        Maths.Initalise();
        Maths.ResetDaySpent();
    }
    

}