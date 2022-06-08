using System.Xml;
using System.Xml.Serialization;

namespace InternalLibrary.DataStorage;

public static class ExportData
{
    public static void Export(string filePath, object config)
    {
        var xmlSerializer = new XmlSerializer(config.GetType());
        using var streamWriter = new StreamWriter(filePath);
        using var xmlWriter = XmlWriter.Create(streamWriter, new XmlWriterSettings { Indent = true });
        xmlSerializer.Serialize(xmlWriter, config);
    }
}