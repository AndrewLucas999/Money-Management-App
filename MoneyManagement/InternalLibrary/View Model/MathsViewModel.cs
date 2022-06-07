using System.ComponentModel;
using InternalLibrary.ObservableObjectVm;

namespace InternalLibrary.View_Model;

public class MathsViewModel : ObserverObject
{
    public Maths Maths { get; } = new ();

    public double TotalDaySpending => Maths.DaySpending.TotalAmountSpentToday;

    public double SinglePurchase => Maths.DaySpending.SinglePurchasePrice;
    // public double DaySpending
    // {
    //     get => Maths.DaySpending.TotalAmountSpentToday;
    //     set
    //     {
    //         Maths.DaySpending.TotalAmountSpentToday = value;
    //         RaisePropertyChanged("DaySpending");
    //     } 
    // }

    public double Cash => Maths.Cash.NewBalance;
    public double AmountToSave => Maths.MoneyAllowance.AmountToSave;
    public MathsViewModel()
    {
        Maths.Initalise();
        Maths.ResetDaySpent();
        RaiseAllPropertiesChanged();
    }
    

}