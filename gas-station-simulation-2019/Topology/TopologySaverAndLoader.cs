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

            Stream saveFileStream = File.Create(fullFilePath);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(saveFileStream, topology);
            saveFileStream.Close();
        }

        public static Topology Load(string fullFilePath)
        {
            if (fullFilePath == null)
                throw new NullReferenceException();

            Topology topology = null;

            Stream openFileStream = File.OpenRead(fullFilePath);
            BinaryFormatter deserializer = new BinaryFormatter();
            topology = (Topology)deserializer.Deserialize(openFileStream);
            openFileStream.Close();

            if (topology == null)
                throw new NullReferenceException();

            return topology;
        }
    }
}