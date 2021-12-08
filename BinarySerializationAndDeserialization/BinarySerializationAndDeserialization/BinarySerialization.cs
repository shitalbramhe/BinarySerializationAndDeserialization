using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationAndDeserialization
{
    public class BinarySerialization
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream filestream = new FileStream(@"E:\RFP\BinarySerializationAndDeserialization\BinarySerializationAndDeserialization\BinarySerializationAndDeserialization\Example.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(filestream, sample);
            Console.ReadKey();
        }
        public void Deserialization()
        {
            FileStream fileStream = new FileStream(@"E:\RFP\BinarySerializationAndDeserialization\BinarySerializationAndDeserialization\BinarySerializationAndDeserialization\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampledemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName { deserializedSampledemo.ApplicationName}     ---      Application ID {deserializedSampledemo.ApplicationId}");
            Console.WriteLine();
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
}
