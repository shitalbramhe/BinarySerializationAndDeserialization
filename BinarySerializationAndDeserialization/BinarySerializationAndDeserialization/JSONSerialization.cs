using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationAndDeserialization
{
    public class JSONSerialization
    {
        public void JsonSerialize()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Shital",
                Description = "Welcome to the Universe"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
            Console.WriteLine();
        }
        public void JsonDeserialize()
        {
            string json = @"{
                    'Name' : 'Shital',
                    'Description' : 'Welcome to the Universe'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
            Console.WriteLine(bsObj.Description);
            Console.WriteLine();
        }
    }
    [DataContract]
    public class BlogSites
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}

