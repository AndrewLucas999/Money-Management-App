using InternalLibrary.Config;

namespace InternalLibrary.View_Model;

public class WindowViewModel
{
    public WindowViewModel()
    {
        
    }
    public void Initalise()
    {
        
    }

    public void ImportAndGenerateMoneyConfig()
    {
        var moneyConfig = MoneyImporter.Import("");
    }
}