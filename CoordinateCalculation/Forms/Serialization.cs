
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using CoordinateCalculation;


namespace Forms
{
    class Serialization
    {
        private static readonly BinaryFormatter _formatter = new BinaryFormatter();

        public static void Serialize(string fileName, List<IMotion> file)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, file);
            }
        }

        public static List<IMotion> Deserialize(string fileName)
        {
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var file = (List<IMotion>)_formatter.Deserialize(fs);
                return file;
            }
        }
    }
}
