using InternalLibrary.Config.IndividualConfig;

namespace InternalLibrary.Config;

public class MoneyConfig
{
    public MonthPay MonthlyPay { get; set; }
    
    public Balance Balance { get; set; }

    public CreditBalance CreditBalance { get; set; }
    
    public DaySpending DaySpending { get; set; }
    
    public MoneyAllowance MoneyAllowance { get; set; }
}