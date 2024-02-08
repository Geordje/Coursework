using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Coursework
{
    public class Serializer
    {
        public static bool SerializePlayer(player objectToSerialize)
        {
            try
            {
                Stream stream = File.Open("SerializedPlayer.bin", FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, objectToSerialize);
                return true;


            }
            catch (Exception)
            {
                return false;
            }
        }
        public static player DeserializePlayer()
        {
            try
            {
                Stream stream = File.Open("SerialisedPlayer.Bin", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                player objectDeSerialized = (player)binaryFormatter.Deserialize(stream);
                stream.Close();

                return objectDeSerialized;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
