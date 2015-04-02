using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace json_serialization
{   public class person
    {
    public string name { get; set; }
    public int age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            serializationjson();
        }
        public static void serializationjson()
        {
            person p = new person();
            p.name = "mahesh";
            p.age = 25;

            MemoryStream stream1 = new MemoryStream();
            DataContractSerializer ser = new DataContractSerializer(typeof(person));
            ser.WriteObject(stream1, p);


            //de -serialization
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            Console.Write("JSON form of Person object: ");
            Console.WriteLine(sr.ReadToEnd());

            Console.Write("Deserialized back, got name=");
            Console.Write(p.name);
            Console.Write(", age=");
            Console.WriteLine(p.age);
           

        }
    }
}
