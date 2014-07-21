using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace HW4
{
    
        public class  XMLfileActions<T>
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

            public void Save(object Obj)
            {
                TextWriter tw = new StreamWriter(filePath);
                XmlSerializer writer = new XmlSerializer(dataType);
                writer.Serialize(tw, Obj);
                tw.Close();
            }

        }
    
}
