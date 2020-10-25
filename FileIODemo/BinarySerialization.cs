using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIODemo
{
    class BinarySerialization
    {
        public void Serialization()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\HP LAPTOP\source\repos\FileIODemo\FileIODemo\sample.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);

        }
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\HP LAPTOP\source\repos\FileIODemo\FileIODemo\sample.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampledemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicatioName { deserializedSampledemo.ApplicationName} ---ApplicationId { deserializedSampledemo.ApplicationId}");
        }

    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }

}
