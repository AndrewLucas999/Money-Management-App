namespace InternalLibrary.View_Model;

public class MathsViewModel
{
    public Maths Maths { get; } = new ();
    public double DaySpending => Maths.DaySpending.TotalAmountSpentToday;
    public double Cash => Maths.Cash.NewBalance;
    public double AmountToSave => Maths.MoneyAllowance.AmountToSave;
    public MathsViewModel()
    {
        Maths.Initalise();
        Maths.ResetDaySpent();
    }
    

}