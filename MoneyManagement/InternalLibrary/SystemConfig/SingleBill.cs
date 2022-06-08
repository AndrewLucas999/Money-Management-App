using System.Xml.Serialization;

namespace InternalLibrary.SystemConfig;

public class SingleBill
{
    [XmlAttribute]
    public string Name { get; set; }
    
    [XmlAttribute]
    public string Cost { get; set; }
}