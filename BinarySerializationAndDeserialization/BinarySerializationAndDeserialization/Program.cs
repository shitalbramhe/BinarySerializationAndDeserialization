using System;

namespace BinarySerializationAndDeserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binaryserialize = new BinarySerialization();
            //binaryserialize.Serialization();
            binaryserialize.Deserialization();
            JSONSerialization jsonserialize = new JSONSerialization();
            jsonserialize.JsonSerialize();
            jsonserialize.JsonDeserialize();
        }
    }
}
