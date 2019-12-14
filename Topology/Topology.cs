using GasStationMs.App.Elements;
using System;
using System.Drawing;

namespace GasStationMs.App.Topology
{
    public class Topology
    {
        private readonly IGasStationElement[,] topology;
        private readonly int rowsCount;
        private readonly int colsCount;

        public Topology(IGasStationElement[,] topology)
        {
            this.topology = topology ?? throw new NullReferenceException();

            rowsCount = topology.GetLength(0);
            colsCount = topology.GetLength(1);
        }

        public int RowsCount { get; }

        public int ColsCount { get; }

        public IGasStationElement this[int x, int y]
        {
            get
            {
                if (x < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (x >= colsCount)
                {
                    throw new IndexOutOfRangeException();
                }

                if (y < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (y >= rowsCount)
                {
                    throw new IndexOutOfRangeException();
                }

                return topology[x, y];
            }
        }

        public IGasStationElement this[Point p]
        {
            get
            {
                if (p.X < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (p.X >= colsCount)
                {
                    throw new IndexOutOfRangeException();
                }

                if (p.Y < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (p.Y >= rowsCount)
                {
                    throw new IndexOutOfRangeException();
                }

                return topology[p.X, p.Y];
            }
        }

        public IGasStationElement GetElement(int x, int y)
        {
            if (x < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (x >= colsCount)
            {
                throw new IndexOutOfRangeException();
            }

            if (y < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (y >= rowsCount)
            {
                throw new IndexOutOfRangeException();
            }

            return topology[x, y];
        }

        public IGasStationElement GetElement(Point p)
        {
            if (p.X < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (p.X >= colsCount)
            {
                throw new IndexOutOfRangeException();
            }

            if (p.Y < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (p.Y >= rowsCount)
            {
                throw new IndexOutOfRangeException();
            }

            return topology[p.X, p.Y];
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
    }
}
