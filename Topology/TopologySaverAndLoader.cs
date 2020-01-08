using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GasStationMs.App.Topology
{
    public static class TopologySaverAndLoader
    {
        public static readonly string Ext = "tplg";
        public static readonly string DotExt = '.' + Ext;
        public static readonly string Filter = ' ' + DotExt + '|' + '*' + DotExt;

        public static void Save(string fullFilePath, Topology topology)
        {
            if (fullFilePath == null ||
                topology == null)
                throw new NullReferenceException();

            using (Stream savingFileStream = File.Create(fullFilePath))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(savingFileStream, topology);
            }
        }

        public static Topology Load(string fullFilePath)
        {
            if (fullFilePath == null)
                throw new NullReferenceException();

            Topology topology = null;

            using (Stream downloadingFileStream = File.OpenRead(fullFilePath))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                topology = (Topology)deserializer.Deserialize(downloadingFileStream);
            }

            if (topology == null)
                throw new NullReferenceException();

            return topology;
        }
    }
}