using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Library
{
    public class XmlOperator<T>
    {
        public T readXML(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            T res =  (T)xs.Deserialize(stream);
            stream.Close();
            return res;
        }
        public void saveXML(string path,T obj)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
            xs.Serialize(stream, obj);
            stream.Close();
        }
        
    }
}