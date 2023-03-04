using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace laba_13
{
    class CustomSerializer
    {
        public static void Serialize(string filename, Check name)
        {
            string[] format = filename.Split('.');
            switch (format[1])
            {
                case "bin":
                    {
                        BinaryFormatter binarForm = new BinaryFormatter();
                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            binarForm.Serialize(fs, name);
                            Console.WriteLine($"Object {typeof(Check)} serialized to {filename}");
                        }
                        break;
                    }
                case "json":
                    {
                        DataContractJsonSerializer jsonForm = new DataContractJsonSerializer(typeof(Check));
                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            jsonForm.WriteObject(fs, name);
                            Console.WriteLine($"Object {typeof(Check)} serialized to {filename}");

                        }
                        break;
                    }
                case "xml":
                    {
                        XmlSerializer xmlSer = new XmlSerializer(typeof(Check));
                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            xmlSer.Serialize(fs, name);
                            Console.WriteLine($"Object {typeof(Check)} serialized to {filename}");

                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong format");
                        break;
                    }
            }
        }

        public static void Deserialize(string fname)
        {
            string[] format = fname.Split('.');
            switch (format[1])
            {
                case "bin":
                    {
                        BinaryFormatter binarForm = new BinaryFormatter();
                        using (FileStream fr = new FileStream(fname, FileMode.Open))
                        {
                            Check newPl = (Check)binarForm.Deserialize(fr);
                            Console.WriteLine("Deserialized from file: " + fname + "\n" + newPl.ToString());
                        }
                        break;
                    }
                case "json":
                    {
                        DataContractJsonSerializer jsonForm = new DataContractJsonSerializer(typeof(Check));
                        using (FileStream fr = new FileStream(fname, FileMode.OpenOrCreate))
                        {
                            Check newPl = (Check)jsonForm.ReadObject(fr);
                            Console.WriteLine("Deserialized from file: " + fname + "\n" + newPl.ToString());
                        }
                        break;
                    }
                case "xml":
                    {
                        XmlSerializer xmlSer = new XmlSerializer(typeof(Check));
                        using (FileStream fr = new FileStream(fname, FileMode.OpenOrCreate))
                        {
                            Check newPl = (Check)xmlSer.Deserialize(fr);
                            Console.WriteLine("Deserialized from file: " + fname + "\n" + newPl.ToString());
                        }
                        break;
                    }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Check check1 = new Check("NewCheck", new DateTime(2022, 11, 14), "Три", "laba_13", 100);
            Check check2 = new Check("NewCheck", new DateTime(2022, 11, 13), "Два", "laba_12", 200);
            Check check3 = new Check("NewCheck", new DateTime(2022, 11, 12), "Один", "laba_11", 300);

            Console.WriteLine("Бинарная сериализация");
            CustomSerializer.Serialize("check1.bin", check1);

            Console.WriteLine("JSON сериализация");
            CustomSerializer.Serialize("check2.json", check2);

            Console.WriteLine("XML сериализация");
            CustomSerializer.Serialize("check3.xml", check3);

            Console.WriteLine("\n\nБинарная десериализация");
            CustomSerializer.Deserialize("check1.bin");

            Console.WriteLine("JSON десериализация");
            CustomSerializer.Deserialize("check2.json");

            Console.WriteLine("XML десериализация");
            CustomSerializer.Deserialize("check3.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<Check>));
            List<Check> checks = new List<Check>();
            checks.Add(check1);
            checks.Add(check2);
            checks.Add(check3);

            using (FileStream fs = new FileStream("Collection.xml", FileMode.Create))
            {
                serializer.Serialize(fs, checks);
            }

            Console.WriteLine("XML сериализация коллекции");
            using (FileStream fr = new FileStream("Collection.xml", FileMode.Open))
            {
                List<Check> newLst = (List<Check>)serializer.Deserialize(fr);
                foreach (var item in newLst)
                {
                    Console.WriteLine($"Десеарелизован: " + item.ToString());
                }
            }

            XmlDocument document = new XmlDocument();
            document.Load("Collection.xml");
            XmlNode xmlRoot = document.DocumentElement;
            XmlNodeList allPlants = xmlRoot.SelectNodes("*");

            int counter = 0;
            foreach (XmlNode node in allPlants)
            {
                counter++;
                Console.WriteLine(counter + ": " + node.InnerText);
            }
            XElement language;
            XElement name;
            XAttribute year;

            XDocument Lang = new XDocument();
            XElement root = new XElement("ЯП");

            language = new XElement("language");
            name = new XElement("name");
            name.Value = "C#";
            year = new XAttribute("year", "1998");
            language.Add(name);
            language.Add(year);
            root.Add(language);

            language = new XElement("language");
            name = new XElement("name");
            name.Value = "C++";
            year = new XAttribute("year", "1983");
            language.Add(name);
            language.Add(year);
            root.Add(language);

            language = new XElement("language");
            name = new XElement("name");
            name.Value = "Java";
            year = new XAttribute("year", "1995");
            language.Add(name);
            language.Add(year);
            root.Add(language);

            Lang.Add(root);
            Lang.Save("Lang.xml");


            Console.WriteLine("Введите год для поиска: ");
            string yearXML = Console.ReadLine();
            var allAlbums = root.Elements("language");

            foreach (var item in allAlbums)
            {
                if (item.Attribute("year").Value == yearXML)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
