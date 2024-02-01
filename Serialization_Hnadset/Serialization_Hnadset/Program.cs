using System.Text.Json;
using System.Xml.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        Person p = new Person();
        p.ToString();

        Console.WriteLine("Xml File is Created...");
        Console.WriteLine("Xml String is Created...");
        Console.WriteLine("Json File is Created...");
    }
}
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public City city { get; set; }

    public void ToString()
    {
        Person personobj = new Person();
        personobj.Name = "A";
        personobj.Age = 1;
        //person.city = "BANG";

        City cityobj = new City();
        cityobj.Name = "B";
        cityobj.Population = 3;

        personobj.city = cityobj;

        #region 2) XML FILE (OBJ -> FILE & FILE -> OBJ) 

        //XmlSerializer xmlser = new XmlSerializer(typeof(Person));      // ser: object -> xml file
        //StreamWriter sw = new StreamWriter("Person.xml");
        //xmlser.Serialize(sw, personobj);
        //sw.Close();

        //XmlSerializer xmldes = new XmlSerializer(typeof(Person));      // des: xml file -> obj
        //StreamReader sr = new StreamReader("Person.xml");
        //var result = (Person)xmldes.Deserialize(sr);
        //Console.WriteLine("Xml file Data: ");
        //Console.WriteLine("Name: " + result.Name);
        //Console.WriteLine("Age: " + result.Age);
        //Console.WriteLine("City Name: " + result.city.Name);
        //Console.WriteLine("City Population: " + result.city.Population);

        #endregion

        #region *) XML STRING (OBJ -> STRING & STRING -> OBJ)

        //XmlSerializer xmlser = new XmlSerializer(typeof(Person));        // Serialize Obj -> String
        //StreamWriter sw = new StreamWriter("Person.xml");
        //xmlser.Serialize(sw, personobj);
        //string xmlStr = sw.ToString();
        //sw.Close();

        //// Deserialize xml string -> object
        //string xmlData = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Person xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Name>A</Name>\r\n  <Age>1</Age>\r\n  <city>\r\n    <Name>B</Name>\r\n    <Population>3</Population>\r\n  </city>\r\n</Person>";

        //StringReader sr = new StringReader(xmlData);
        //var resultStr = (Person)xmlser.Deserialize(sr);       // var bcs StringReader (strReader) is an object // Des the ser and read it
        //Console.WriteLine("Xml String Data: ");
        //Console.WriteLine("Name: " + resultStr.Name);
        //Console.WriteLine("Age: " + resultStr.Age);
        //Console.WriteLine("City Name: " + resultStr.city.Name);
        //Console.WriteLine("City Population: " + resultStr.city.Population);

        #endregion

        #region 3) JSON STRING

        //string jsonStr = JsonSerializer.Serialize(personobj);                 // Ser: obj Json -> string json
        //StreamWriter sw = new StreamWriter("Person.json");
        //sw.WriteLine(jsonStr);      // Json -> string so directly console.writeline
        //sw.Close();


        //StreamReader sr = new StreamReader("Person.json");                    // DeSer: string Json -> obj json
        //string jsonstr = sr.ReadToEnd();
        //Person personJson = JsonSerializer.Deserialize<Person>(jsonstr);

        //Console.WriteLine("Json File Data: ");
        //Console.WriteLine("Name: " + personJson.Name);
        //Console.WriteLine("Age: " + personJson.Age);
        //Console.WriteLine("City Name: " + personJson.city.Name);
        //Console.WriteLine("City Population: " + personJson.city.Population);

        #endregion
    }
}
    
public class City
{
    public string Name { get; set; }

    public int Population { get; set; }
}
