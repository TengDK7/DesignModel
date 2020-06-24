using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    class Screen
    {
        public string Name
        {
            get;set;
        }
    }
    class OppoPhone
    {
        public Screen Screen { get; set; }
        public string Name { get { return "Oppo"; } }

        public OppoPhone Clone()
        {
            OppoPhone clone = new OppoPhone();
            FileStream stream = new FileStream("./apptest.txt",FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this.Screen);
            stream.Close();

            FileStream fileStream = new FileStream("./apptest.txt", FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            clone.Screen = (Screen)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return clone;
        }
        public OppoPhone WiseClone()
        {
            return (OppoPhone)this.MemberwiseClone();
        }
    }
}
