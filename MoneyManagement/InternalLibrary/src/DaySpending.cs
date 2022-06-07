namespace InternalLibrary;

public class DaySpending
{
    public static List<double> ListOfDaySpending = new List<double>()
    {
        5.99,
        30.1
    };

    public double TotalAmountSpentToday { get; set; } = 0;
    // public double TotalAmountSpentToday { get; set; } = ListOfDaySpending.Sum(Convert.ToDouble);
    public double SinglePurchasePrice { get; set; } 
    public void AddIndividualAmount(string text)
    {
        var singlePrice = Convert.ToDouble(text);
        SinglePurchasePrice = singlePrice;
        TotalAmountSpentToday = TotalAmountSpentToday + SinglePurchasePrice;
    }

}