using GasStationMs.App.Elements;
using GasStationMs.App.TemplateElements;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GasStationMs.App.Topology
{
    [Serializable()]
    public partial class Topology
    {
        private readonly IGasStationElement[,] field;
        private int serviceAreaBorderColIndex;

        public Topology(IGasStationElement[,] field, int serviceAreaBorderColIndex)
        {
            this.field = field ?? throw new NullReferenceException();
            this.serviceAreaBorderColIndex = serviceAreaBorderColIndex;
        }

        public int RowsCount
        {
            get
            {
                return field.GetLength(0);
            }
        }

        public int ColsCount
        {
            get
            {
                return field.GetLength(1);
            }
        }

        public int ServiceAreaBorderColIndex { get; }

        public int LastX
        {
            get
            {
                return ColsCount - 1;
            }
        }

        public int LastY
        {
            get
            {
                return RowsCount - 1;
            }
        }

        public Point FirstBorderPoint
        {
            get
            {
                return new Point(serviceAreaBorderColIndex, 0);
            }
        }

        public IGasStationElement this[int x, int y]
        {
            get
            {
                if (y < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (y > LastY)
                {
                    throw new IndexOutOfRangeException();
                }

                if (x < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (x > LastX)
                {
                    throw new IndexOutOfRangeException();
                }

                return field[y, x];
            }
        }

        public IGasStationElement this[Point p]
        {
            get
            {
                return this[p.X, p.Y];
            }
        }

        public IGasStationElement GetElement(int x, int y)
        {
            if (x < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (x >= ColsCount)
            {
                throw new IndexOutOfRangeException();
            }

            if (y < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (y >= RowsCount)
            {
                throw new IndexOutOfRangeException();
            }

            return field[y, x];
        }

        public IGasStationElement GetElement(Point p)
        {
            return GetElement(p.X, p.Y);
        }

        public bool IsCashCounter(int x, int y)
        {
            return this[x, y] is CashCounter;
        }

        public bool IsCashCounter(Point p)
        {
            return this[p] is CashCounter;
        }

        public bool IsEntry(int x, int y)
        {
            return this[x, y] is Entry;
        }

        public bool IsEntry(Point p)
        {
            return this[p] is Entry;
        }

        public bool IsExit(int x, int y)
        {
            return this[x, y] is Exit;
        }

        public bool IsExit(Point p)
        {
            return this[p] is Exit;
        }

        public bool IsFuelDispenser(int x, int y)
        {
            return this[x, y] is FuelDispenser;
        }

        public bool IsFuelDispenser(Point p)
        {
            return this[p] is FuelDispenser;
        }

        public bool IsFuelTank(int x, int y)
        {
            return this[x, y] is FuelTank;
        }

        public bool IsFuelTank(Point p)
        {
            return this[p] is FuelTank;
        }

        public bool IsRoad(int x, int y)
        {
            return this[x, y] is Road;
        }

        public bool IsRoad(Point p)
        {
            return this[p] is Road;
        }

        public bool IsServiceArea(int x, int y)
        {
            return this[x, y] is ServiceArea;
        }

        public bool IsServiceArea(Point p)
        {
            return this[p] is ServiceArea;
        }

        public static string DotExt
        {
            get
            {
                return ".tplg";
            }
        }

        public void Save(string currFilePath)
        {
            Stream savingFileStream = File.Create(currFilePath);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(savingFileStream, this);
            savingFileStream.Close();
        }
    }
}
