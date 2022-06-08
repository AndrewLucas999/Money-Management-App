using System.Xml.Serialization;
namespace InternalLibrary.SystemConfig;

public class SystemConfig
{
    public BillsConfig[] BillsConfig { get; set; }
    public string Balance { get; set; }
    public string MonthSalary { get; set; }
}