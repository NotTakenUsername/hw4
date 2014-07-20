using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.Threading.Tasks;
using HW3;
using System.IO;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> Workers = new List<Worker>();
            Worker testw = new Worker();
            XMLfile(testw); //concern about <T>


        }

        /* public void DeserializeWorkers(string ListOfWorkers)
         {
             List<Worker> Workers = new List<Worker>();
             Console.WriteLine("Reading with XmlReader");
             // Create an instance of the XmlSerializer specifying type and namespace.
             XmlSerializer serializer = new XmlSerializer(typeof(Worker));
             Stream serialStream = new FileStream("ListOfWorkers.xml", FileMode.Open);//cannot convert from 'System.IO.Stream' to 'System.Xml.XmlReader'	
             Workers.Add = serializer.Deserialize(serialStream);
         }*/
    }

    public class XMLfile<T>
    {
        Type dataType;
        string filePath;
        public void XMLFile(string filePath)
        {
            this.filePath = filePath + ".xml";
            dataType = typeof(T);
        }

        public T Load()
        {
            TextReader tr = new StreamReader("ListOfWorkers.xml");
            XmlSerializer reader = new XmlSerializer(dataType);
            T instance = (T)reader.Deserialize(tr);
            tr.Close();
            return instance;
        }

    }
}
