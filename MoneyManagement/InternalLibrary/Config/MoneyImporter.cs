using System.Xml.Serialization;

namespace InternalLibrary.Config;

public class MoneyImporter
{
    public static MoneyConfig Import(string filepath)
    {
        try
        {
            var reader = new XmlSerializer(typeof(MoneyConfig));
            using var file = new StreamReader(filepath);
            var money = (MoneyConfig)reader.Deserialize(file)!;
            file.Close();
            return money;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}