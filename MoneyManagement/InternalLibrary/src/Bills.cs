namespace InternalLibrary;

public class Bills
{
    // Takes user inputted values and adds to a list which is then accessible 
    // TODO - Temporary Bills input
    public static List<double> BillsToPay = new List<double>()
    {
        565,
        40,
        83,
        90.8
    };

    public double TotalBill { get; set; } = BillsToPay.Sum(Convert.ToDouble);
}