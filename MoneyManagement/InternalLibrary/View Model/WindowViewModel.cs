using InternalLibrary.Config;

namespace InternalLibrary.View_Model;

public class WindowViewModel
{
    public MathsViewModel MathsViewModel { get; set; } = new();

    public void ImportAndGenerateMoneyConfig()
    {
        var moneyConfig = MoneyImporter.Import("");
    }
}