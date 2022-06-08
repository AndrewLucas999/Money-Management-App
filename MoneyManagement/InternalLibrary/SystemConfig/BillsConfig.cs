using System.Xml.Serialization;

namespace InternalLibrary.SystemConfig;

public class BillsConfig
{
    [XmlAttribute]
    public SingleBill SingleBill { get; set; }
    
}