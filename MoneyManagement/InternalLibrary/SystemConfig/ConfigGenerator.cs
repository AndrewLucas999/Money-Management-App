using InternalLibrary.DataStorage;

namespace InternalLibrary.SystemConfig;

public class ConfigGenerator
{
    /// <summary>
    ///     The folder for system data, which is %APPDATA%\Tempo
    /// </summary>
    public static readonly string SystemFolder =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MoneyManager";
    public static void CreateSystemConfigTemplate()
    {
        var fileLocation = SystemFolder;
        if (File.Exists(fileLocation)) return;
        ExportData.Export(fileLocation, SystemConfig);
    }
    
    private static readonly SystemConfig SystemConfig = new SystemConfig()
    {
        Balance = "0",
        BillsConfig = new[]
        {
            new BillsConfig
            {
                SingleBill = new SingleBill()
                {
                    Cost = "",
                    Name = "Rent"
                }
            }
        },
        MonthSalary = "0"
    };
}