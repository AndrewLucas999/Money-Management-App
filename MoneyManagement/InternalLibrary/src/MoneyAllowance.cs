namespace InternalLibrary;

public class MoneyAllowance
{
    // Calculate amount to save Lets say 10 % of whats left over
    public double AmountToSave { get; set; }
    public void CalculateAmountToSave(double balance ,double percentageSave)
    {
        var decimalPercentage = percentageSave / 100;
        AmountToSave = balance * decimalPercentage;
    }
}